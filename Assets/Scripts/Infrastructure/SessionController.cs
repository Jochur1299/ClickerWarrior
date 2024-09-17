using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SessionController : MonoBehaviour
{
    [SerializeField] private FightController fightController;
    [SerializeField] private List<EnemyData> enemiesModels = new();
    
    
    private void Start()
    {
        fightController.OnIsPlayerDead += CheckEndGame;
        fightController.OnIsEnemiesDead += CheckEndGame;
        
        var player = CreatePlayer();
        var enemies = GetEnemies();
        fightController.Init(player,enemies);
    }

    private void CheckEndGame()
    {
       
    }
    
    private Player CreatePlayer() //TODO create player by player model
    {
        return new Player("rob", 300, 10);
    }

    private List<Enemy> GetEnemies()
    {
        var enemies = new List<Enemy>();
        foreach (var enemy in enemiesModels.ToList())
        {
            enemies.Add(new Enemy(enemy.Image,enemy.Name,enemy.Health,enemy.Power));
        }
        return enemies;
    }
}