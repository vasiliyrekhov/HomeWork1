using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotWeapon : MonoBehaviour, IWeapon
{
    [SerializeField]
    public int BulletCount = 10;
    public void Shoot()
    {
        if (BulletCount > 0) 
        {
            Debug.Log("��������� �������, �������� �������� " + BulletCount);
            BulletCount--;
        } 
        else
        {
            Debug.Log("��������� �������");
        }
 
    }
}
