using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FightController : MonoBehaviour
{
    public Button knopka;
    public Button restartButton;
    public Slider healthBarPlayer;
    public Slider healthBarEnemy;
    public TextMeshProUGUI restart;
    public TextMeshProUGUI winPlayer;
    public TextMeshProUGUI winEnemy;
    private Human rob;
    private Human enemy;
    public List<EnemyData> enemys = new List<EnemyData> {};
    public EnemyView enemyView;
    public Button changeEnemy;
    private void Start()
    {
        Change();
        rob = new("rob", 300, 10);
        rob.OnHealthChange += SetPlayerHealth;
        enemy.OnHealthChange += SetEnemyHealth;
        InitHealtbars(rob, enemy);
        knopka.onClick.AddListener(() => DoDamage(rob, enemy));
        restartButton.onClick.AddListener(Restart);
        changeEnemy.onClick.AddListener(Change);
    }

    private void InitHealtbars(Human rob, Human enemy)
    {
        healthBarPlayer.maxValue = rob.Health;
        healthBarPlayer.value = rob.Health;
        healthBarEnemy.maxValue = enemy.Health;
        healthBarEnemy.value = enemy.Health;
    }

    public void SetPlayerHealth(int playerHealth)
    {
        healthBarPlayer.value = playerHealth;
    }
    public void SetEnemyHealth(int enemyHealth)
    {
        healthBarEnemy.value = enemyHealth;
    }
    public void ChekEndGame(Human rob, Human enemy)
    {
        if (rob.Health <= 0)
        {
            
        }
        else if (enemy.Health <= 0)
        {
            Change();
        }
    }
    public void Damage (Human player, Human enemy)
    {
        player.TakeDamage(ModDamage(enemy.Power));
    }
    public void DoDamage(Human rob, Human enemy)
    {
        int turn = Random.Range(1, 3);
        Debug.Log(turn);
        if (turn == 1)
        {
           Damage(rob, enemy);
        }
        else
        {
            Damage(enemy, rob);
        }
        ChekEndGame(rob, enemy);
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
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    private void OnDestroy()
    {
        rob.OnHealthChange -= SetPlayerHealth;
        enemy.OnHealthChange -= SetEnemyHealth;
    }
    int count = 0;
    public void Change()
    {
        count++;
        enemyView.SetAvatar(enemys[count].image);
        if (count >= 2) 
        {
            count = 0;
        }
    }
}
