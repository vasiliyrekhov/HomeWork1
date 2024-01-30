using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTradingStrategy : ITradingStrategy
{
    public void Trade(ICustomer customer)
    {
        customer.Trading("Торгую фруктами");
    }
}
