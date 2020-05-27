using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            IBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);

            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
        }
    }
}
