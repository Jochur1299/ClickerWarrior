using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FightController : MonoBehaviour
{
    public event Action OnIsPlayerDead; 
    public event Action OnIsEnemiesDead;

    [SerializeField] private EnemyView enemyView;
    
    private List<Enemy> enemieslist = new();
    private Enemy currentEnemy;
    
    public void Init(Player player, List<Enemy> enemys)
    {
        enemieslist = enemys;
        currentEnemy = enemys[Random.Range(0, enemys.Count)];
        InitEnemyView();
        PlayerInputClicker.OnClick += () => DoPlayerDamage(player);
    }

    private void InitEnemyView()
    {
        enemyView.Init(currentEnemy);
        enemyView.HealthBarView.SetMaxValue(currentEnemy.Health);
        enemyView.HealthBarView.UpdateHealthBar(currentEnemy.Health);
    }

    private void DoPlayerDamage(Player player)
    {
        currentEnemy.TakeDamage(DamageHalper.ModDamage(player.Power));
        enemyView.HealthBarView.UpdateHealthBar(currentEnemy.Health);
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
                InitEnemyView();
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