using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    public IEnumerable<CoffeeType> CoffeesSold
    {
        get { return this.coffeeSold; }
    }

    private int coins;
    private IList<CoffeeType> coffeeSold;

    public CoffeeMachine()
    {
        this.coffeeSold = new List<CoffeeType>();
    }

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice cofeePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType cofeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        if (this.coins >= (int)cofeePrice)
        {
            this.coffeeSold.Add(cofeeType);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        Coin cointCoin = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int) cointCoin;
    }
}