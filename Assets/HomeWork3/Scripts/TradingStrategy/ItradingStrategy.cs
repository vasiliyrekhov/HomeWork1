using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITradingStrategy
{
    void Trade(ICustomer customer);
}