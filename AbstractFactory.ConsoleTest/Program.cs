using AbstractFactory.Pattern.Stores;
using AbstractFactory.Pattern.Stores.Abstract;
using System;

namespace AbstractFactory.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order a New York Chesse Pizza
            PizzaStore nyPizzaStore = new NYPizzaStore();
            var pizza = nyPizzaStore.OrderPizza("cheese");

            Console.WriteLine(pizza.name);
            Console.ReadKey();
        }
    }
}
