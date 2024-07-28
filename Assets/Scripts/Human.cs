using UnityEngine;

public class Human
{
    private string name { get; set; }
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
    public void win(string name)
    {
        Debug.Log(name + " победил!");
    }
    public void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0) 
        {
            Debug.Log(name + " умер");
        }
    }
    
}