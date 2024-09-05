using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemy", menuName = "Entities/enemys")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private Sprite _image;
    [SerializeField] private string _name;
    [SerializeField] private int _power;
    [SerializeField] private int _health;

    public Sprite image => this.image;
    public string name => this._name;
    public int power => this._power;
    public int health => this._health;
}
