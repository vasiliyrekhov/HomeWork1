using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllBallsStrategy : IWinCondition
{
    public bool HasWon(List<Ball> balls)
    {
        foreach (Ball ball in balls)
        {
            if (!ball.isPopped)
            {
                return false; // Возвращаем false, если хотя бы один шарик не лопнут
            }
        }
        return true; // Все шарики лопнуты
    }
}
