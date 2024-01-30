using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    public event Action OnBallClicked;
    public enum ColorType
    {
        White,
        Red,
        Green
    }

    public ColorType color;
    public bool isPopped;

    private void Awake()
    {
        isPopped = false;
    }

    private void OnMouseDown()
    {
        //Debug.Log("Клик по шарику" + color);
        isPopped = true;
        OnBallClicked?.Invoke();                // Вызов события
        gameObject.SetActive(false);
    }
}
