using System;

public class Player : IDisposable
{
    public event Action<int> OnHealthChange;
    
    private string name;
    private int power;
    private int health;
    
    public string Name => name;
    public int Health => health;
    public int Power => power;

    public Player(string name, int health, int power)
    {
        this.name = name;
        this.health = health;
        this.power = power;
    }
    
    public void TakeDamage(int value)
    {
        health -= value;
        OnHealthChange?.Invoke(health);
    }

    public void Dispose()
    {
        OnHealthChange = null;
    }
}