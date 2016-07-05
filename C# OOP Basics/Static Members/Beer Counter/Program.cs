using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var beerParams = input.Split();
            var boughtBeers = int.Parse(beerParams[0]);
            var drankBeers = int.Parse(beerParams[0]);

            BeerCounter.BuyBeer(boughtBeers);
            BeerCounter.DrinkBeer(drankBeers);

            input = Console.ReadLine();
        }

        Console.WriteLine($"{BeerCounter.BeerInStock} {BeerCounter.BeersDrankCount}");
    }
}

public static class BeerCounter
{
    public static int BeerInStock;
    public static int BeersDrankCount;

    public static void BuyBeer(int bottlesCount)
    {
        BeerInStock += bottlesCount;
    }
    public static void DrinkBeer(int bottlesCount)
    {
        BeersDrankCount += bottlesCount;
        BeerInStock -= bottlesCount;
        if (BeerInStock < 0)
        {
            BeerInStock = 0;
        }
    }
}