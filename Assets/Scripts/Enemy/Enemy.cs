using UnityEngine;

public class Enemy
{
    public Sprite enemyAvatar { get; set; }
    public string Name { get; }
    public int Health { get; set; }
    public int Power { get; set; }

    public Enemy(Sprite enemyAvatar, string name, int health, int power)
    {
        this.enemyAvatar = enemyAvatar;
        Name = name;
        Health = health;
        Power = power;
    }
}