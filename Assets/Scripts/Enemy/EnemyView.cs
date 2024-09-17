using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyView : MonoBehaviour
{
    [SerializeField] private Image enemyAvatar;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private EnemyHealthBarView healthBarView;
    
    public EnemyHealthBarView HealthBarView => healthBarView;
    
    public void Init(Enemy enemyData)
    {
        enemyAvatar.sprite = enemyData.enemyAvatar;
        name.text = enemyData.Name;
    }
    
   
}
