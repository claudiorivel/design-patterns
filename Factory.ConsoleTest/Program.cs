using Factory.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Pattern.Abstract;

namespace Factory.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " +pizza.GetName());

            Console.ReadKey();
        }
    }
}
