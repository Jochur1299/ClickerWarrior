using System.Collections;
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
        restartButton.onClick.AddListener(Restart);
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
            Win(rob.Name);
            winEnemy.gameObject.SetActive(true);
        }
        else if (enemy.Health <= 0) 
        {
            Win(enemy.Name);
            winPlayer.gameObject.SetActive(true);
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
    public void Win(string name)
    {
        knopka.gameObject.SetActive(false);
        restart.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        Debug.Log(name + " победил!");
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
