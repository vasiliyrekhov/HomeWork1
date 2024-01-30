using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private WeaponController _weaponControler;

    private void Start()
    {
        _weaponControler = GetComponentInChildren<WeaponController>();

        if (_weaponControler != null)
        {
            Debug.Log("������ �� weaponControler ��������");
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("������ ������ ���� - �����");
            _weaponControler.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Debug.Log("������ ������ Q - ����� ������");
            _weaponControler.ChangeWeapon();
        }
    }

}
