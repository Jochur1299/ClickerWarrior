using System;
using UnityEngine;

public class PlayerInputClicker : MonoBehaviour
{
    public static Action OnClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick?.Invoke();
        }
    }
}