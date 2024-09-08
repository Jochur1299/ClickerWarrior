using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FightController : MonoBehaviour
{
    public event Action OnIsPlayerDead; 
    public event Action OnIsEnemiesDead; 

    private List<Enemy> enemieslist = new();
    private Enemy currentEnemy;
    
    public void Init(Player player, List<Enemy> enemys) 
    {
        enemieslist = enemys;
        // var a = Random.Range(0, enemys.Count);
        currentEnemy = enemys[Random.Range(0, enemys.Count)];
        
        PlayerInputClicker.OnClick += () => DoPlayerDamage(player);
    }

    private void DoPlayerDamage(Player player)
    {
        player.TakeDamage(DamageHalper.ModDamage(currentEnemy.Power));
        IsEnemyDead();
    }

    private void IsEnemyDead()
    {
        if (currentEnemy.Health <= 0)
        {
            for (var i = 0; i < enemieslist.Count; i++)
            {
                if (enemieslist[i] == currentEnemy)
                {
                    enemieslist.Remove(enemieslist[i]);
                    break;
                }
            }

            if (enemieslist.Count != 0)
            {
                currentEnemy = enemieslist[Random.Range(0, enemieslist.Count)];
            }
            else
            {
                OnIsEnemiesDead?.Invoke();
            }
        }
    }


    private void OnDestroy()
    {
        PlayerInputClicker.OnClick = null;
        //enemy.OnHealthChange -= SetEnemyHealth;
    }

}