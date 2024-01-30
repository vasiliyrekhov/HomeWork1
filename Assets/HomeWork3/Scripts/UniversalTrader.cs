using UnityEngine;

public class UniversalTrader : Trader
{
    private ITradingStrategy tradingStrategy;

    protected override void StartTrading(ICustomer customer)
    {
        if (customer.Reputation < 5)
        {
            tradingStrategy = new NoTradingStrategy();
        }
        else if (customer.Reputation > 5 && customer.Reputation < 10)
        {
            tradingStrategy = new ArmorTradingStrategy();
        }
        else if (customer.Reputation > 10)
        {
            tradingStrategy = new FruitTradingStrategy();
        }

        tradingStrategy.Trade(customer);
    }
}