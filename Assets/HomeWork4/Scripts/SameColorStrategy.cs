using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SameColorStrategy : IWinCondition
{
    public bool HasWon(List<Ball> balls)
    {
        Dictionary<Ball.ColorType, int> poppedCounts = new Dictionary<Ball.ColorType, int>();

        foreach (Ball ball in balls)
        {
            if (ball.isPopped)
            {
                if (poppedCounts.ContainsKey(ball.color))
                {
                    poppedCounts[ball.color]++;
                }
                else
                {
                    poppedCounts[ball.color] = 1;
                }
            }
        }

        foreach (var count in poppedCounts)
        {
            int totalColorBalls = balls.Count(ball => ball.color == count.Key);

            if (count.Value >= totalColorBalls)
            {
                return true;
            }
        }

        return false;
    }
}
