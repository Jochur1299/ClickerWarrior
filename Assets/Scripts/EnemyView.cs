using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyView : MonoBehaviour
{
    public Image enemyAvatar;
    public TextMeshProUGUI name;
 
    public void SetAvatar (Sprite avatar)
    {
        enemyAvatar.sprite = avatar;
    }
}
