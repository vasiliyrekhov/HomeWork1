using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotWeapon : MonoBehaviour, IWeapon
{
    [SerializeField]
    public int BulletCount = 15;
    public void Shoot()
    {
        if (BulletCount > 2)
        {
            Debug.Log("������� �������, �������� �������� " + BulletCount);
            BulletCount -= 3;
        }
        else
        {
            Debug.Log("��������� �������");
        }

    }
}
