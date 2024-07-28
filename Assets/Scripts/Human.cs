using UnityEngine;

public class Human
{
    private string name;
    public string Name { get { return name; } }
   
    private int health;
    public int Health 
    {
        get { return health; }
        set { health = value; }
    }
    private int power;
    public int Power 
    {
        get { return power; }
        set { power = value; }
    }


    public Human()
    {
        name = "Default";
        health = 1;
        power = 1;
    }
    public Human(string name, int health, int power)
    {
        this.name = name;
        this.health = health;
        this.power = power;
    }
    public void TakeDamage(int value)
    {
        health -= value;
        
    }
    
}