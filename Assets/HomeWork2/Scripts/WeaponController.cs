using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private List<IWeapon> weapons = new List<IWeapon>();                //������ ����������� ������
    private List<GameObject> weaponObjects = new List<GameObject>();    //������ �������� ������
    private int currentWeaponIndex = 0;
    private void Start()
    {
        // �������� ��� ���������� IWeapon � �� �������
        foreach (Transform child in transform)
        {
            IWeapon weaponComponent = child.GetComponent<IWeapon>() as IWeapon;
            if (weaponComponent != null)
            {
                weapons.Add(weaponComponent);
                weaponObjects.Add(child.gameObject);
            }
        }

        // ���������� ������ ������
        weaponObjects[currentWeaponIndex].SetActive(true);

        // ������� ��������� �� �������� ��������� ������ �� ������
        foreach (IWeapon weapon in weapons)
        {
            Debug.Log("������ �� " + weapon.GetType().Name + " ��������");
        }
    }
    public void Shoot()
    {
        // �������� ����� Shoot() �� ������� ������
        weapons[currentWeaponIndex].Shoot();
    }

    public void ChangeWeapon()
    {
        // ��������� ������� ������
        weaponObjects[currentWeaponIndex].SetActive(false);

        // ������������� �� ��������� ������
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;

        // ���������� ����� ������
        weaponObjects[currentWeaponIndex].SetActive(true);
    }
}
