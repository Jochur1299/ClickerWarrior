using UnityEngine;
using UnityEngine.UI;

public class Enemy
{
    public  Sprite enemyAvatar;
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

}
