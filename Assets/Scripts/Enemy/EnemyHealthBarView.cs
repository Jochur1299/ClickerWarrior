using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarView : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
        
    private float maxValue;
    
    public void UpdateHealthBar(float value)
    {
        healthBar.value = value / maxValue;
    }

    public void SetMaxValue(float value)
    {
        maxValue = value;
    }
}