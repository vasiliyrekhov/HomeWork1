using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IWinCondition
{
    bool HasWon(List<Ball> balls); // Метод для проверки условия победы
}
