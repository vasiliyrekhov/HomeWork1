using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    [SerializeField] private Level _level;
    [SerializeField] private GameObject _interfaceWindow; // Ссылка на объект, представляющий окно интерфейса

    public void GlobalDestructionButtonPressed()
    {
        _level.ChooseWinCondition((int)UIButtons.AllBalls);
        _interfaceWindow.SetActive(false); // Отключение окна интерфейса
    }

    public void ColorGonocideButtonPressed()
    {
        _level.ChooseWinCondition((int)UIButtons.SameColorBalls);
        _interfaceWindow.SetActive(false); // Отключение окна интерфейса
    }
}
