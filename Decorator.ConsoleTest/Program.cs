using Decorator.Pattern.Classes.Beverages;
using Decorator.Pattern.Classes.Condiments;
using System;
using Decorator.Pattern.Classes;

namespace Decorator.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new DarkRoast();
            Console.WriteLine($"Description: {beverage.GetDescription()}; Cost: {beverage.Cost()}");

            var beverage2 = new HouseBlend();
            var decorator1 = new Mocha(beverage2);
            var decorator2 = new Milk(decorator1);

            Console.WriteLine($"Description: {decorator2.GetDescription()}; Cost: {decorator2.Cost()}");

            Console.ReadKey();

        }
    }
}
