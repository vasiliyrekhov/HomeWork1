using System;
using UnityEngine;

public abstract class Trader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICustomer customer))
        {
            //Debug.Log(" покупка происходит ");

            StartTrading(customer);
        }
    }

    protected abstract void StartTrading(ICustomer customer);
}