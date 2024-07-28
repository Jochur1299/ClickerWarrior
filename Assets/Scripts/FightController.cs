using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FightController : MonoBehaviour
{
    public Button knopka;
    public Slider healthBarPlayer;
    public Slider healthBarEnemy;
    public TextMeshProUGUI restart;

    private void Start()
    {
        Human rob = new("rob", 300, 10);
        Human enemy = new("joe", 15, 10);
        healthBarPlayer.maxValue = rob.Health;
        healthBarPlayer.value = rob.Health;
        healthBarEnemy.maxValue = enemy.Health;
        healthBarEnemy.value = enemy.Health;
        knopka.onClick.AddListener(Click);
        knopka.onClick.AddListener(()=>DoDamage(rob,enemy));
    }
    public void Click()
    {
        Debug.Log("Click");
    }
    public void DoDamage(Human rob, Human enemy)
    {
        ShowInfo(rob, enemy);
        enemy.TakeDamage(ModDamage(enemy.Power));
        healthBarEnemy.value = enemy.Health;
        rob.TakeDamage(ModDamage(rob.Power));
        healthBarPlayer.value = rob.Health;
        ShowInfo(rob, enemy);
        if (rob.Health <= 0) 
        {
            win(rob.Name);
        }
        else if (enemy.Health <= 0) 
        {
            win(enemy.Name);
        }
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
    public void win(string name)
    {
        knopka.enabled= false;
         
        Debug.Log(name + " победил!");
    }
}
