using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Entities/enemys")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private Sprite image;
    [SerializeField] private string name;
    [SerializeField] private int power;
    [SerializeField] private int health;

    public Sprite Image => image;
    public string Name => name;
    public int Power => power;
    public int Health => health;
}
