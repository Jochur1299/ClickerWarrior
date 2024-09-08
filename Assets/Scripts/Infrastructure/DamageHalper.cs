using UnityEngine;

public static class DamageHalper
{
    public static int ModDamage(int power)
    {
        var damage = 1;
        var modDamage = Random.Range(1, 10);
        if (modDamage is 1 or 2)
        {
            damage = power / 2;
        }
        else if (modDamage is 9 or 10)
        {
            damage = power * 2;
        }
        else
        {
            damage = power;
        }

        return damage;
    }
}