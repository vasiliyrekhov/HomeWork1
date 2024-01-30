using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField]
    private List<Ball> balls = new List<Ball>();    // Список шариков на уровне    

    private IWinCondition winCondition;             // Поле для текущей стратегии победы

    private void Start()
    {
        // Подписка на событие OnBallClicked для каждого шарика
        foreach (Ball ball in balls)
        {
            ball.OnBallClicked += CheckWinCondition;
        }
    }

    public void ChooseWinCondition(int choice)
    {
        if (choice == (int)UIButtons.AllBalls)
        {
            Debug.Log("Выбран режим GlobalDestruction");
            winCondition = new AllBallsStrategy(); // Выбор стратегии "лопнуть все шарики"
        }
        else if (choice == (int)UIButtons.SameColorBalls)
        {
            Debug.Log("Выбран режим SameColorBalls");
            winCondition = new SameColorStrategy(); // Выбор стратегии "лопнуть шарики одного цвета"
        }
    }
    private void CheckWinCondition()
    {
        if (winCondition != null && winCondition.HasWon(balls))
        {
            Debug.Log("Победа!");
        }
    }
}

public enum UIButtons
{
    AllBalls = 1,
    SameColorBalls = 2
}
