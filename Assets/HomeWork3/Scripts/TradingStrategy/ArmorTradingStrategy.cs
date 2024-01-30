using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTradingStrategy : ITradingStrategy
{
    public void Trade(ICustomer customer)
    {
        customer.Trading("Торгую бронёй");
    }
}
