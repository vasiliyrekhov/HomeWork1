using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTradingStrategy : ITradingStrategy
{
    public void Trade(ICustomer customer)
    {
        customer.Trading("С тобой не торгую");
    }
}
