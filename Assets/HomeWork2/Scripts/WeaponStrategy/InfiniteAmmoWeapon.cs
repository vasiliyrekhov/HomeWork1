using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteAmmoWeapon : MonoBehaviour, IWeapon
{
    public void Shoot()
    {
       Debug.Log("Одиночный выстрел");
    }
}
