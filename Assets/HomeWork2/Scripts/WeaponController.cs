using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private List<IWeapon> weapons = new List<IWeapon>();                //Список интерфейсов оружия
    private List<GameObject> weaponObjects = new List<GameObject>();    //Список объектов оружия
    private int currentWeaponIndex = 0;
    private void Start()
    {
        // Получаем все компоненты IWeapon и их объекты
        foreach (Transform child in transform)
        {
            IWeapon weaponComponent = child.GetComponent<IWeapon>() as IWeapon;
            if (weaponComponent != null)
            {
                weapons.Add(weaponComponent);
                weaponObjects.Add(child.gameObject);
            }
        }

        // Активируем первое оружие
        weaponObjects[currentWeaponIndex].SetActive(true);

        // Выводим сообщение об успешном получении ссылок на оружия
        foreach (IWeapon weapon in weapons)
        {
            Debug.Log("Ссылка на " + weapon.GetType().Name + " получена");
        }
    }
    public void Shoot()
    {
        // Вызываем метод Shoot() на текущем оружии
        weapons[currentWeaponIndex].Shoot();
    }

    public void ChangeWeapon()
    {
        // Отключаем текущее оружие
        weaponObjects[currentWeaponIndex].SetActive(false);

        // Переключаемся на следующее оружие
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;

        // Активируем новое оружие
        weaponObjects[currentWeaponIndex].SetActive(true);
    }
}
