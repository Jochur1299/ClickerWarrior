using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightController : MonoBehaviour
{
    public Button knopka;
    public Slider healthBar;

    private void Start()
    {
        Human rob = new("rob", 120, 16);
        Human joe = new("joe", 45, 32);
        //rob.fight(rob,joe);
        knopka.onClick.AddListener(Click);
        knopka.onClick.AddListener(()=>DoDamage(rob,joe));
    }
    public void Click()
    {
        Debug.Log("Click");
    }
    public void DoDamage(Human rob, Human joe)
    {
        ShowInfo(rob, joe);
        joe.TakeDamage(ModDamage(rob.Power));
        healthBar.value = joe.Health;
        ShowInfo(rob, joe);
    }
    public void ShowInfo (Human rob, Human joe)
    {
        Debug.Log(joe.Health);
        Debug.Log(rob.Health);
    }
    public int ModDamage(int power)
    {
        int damage = 1;
        int modDamage = Random.Range(1, 10);
        if (modDamage == 1 || modDamage == 2)
        {
            damage = power / 2;
        }
        else if (modDamage == 9 || modDamage == 10)
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
