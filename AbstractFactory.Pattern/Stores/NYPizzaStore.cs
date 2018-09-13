using AbstractFactory.Pattern.Factories;
using AbstractFactory.Pattern.Factories.Interfaces;
using AbstractFactory.Pattern.Pizzas;
using AbstractFactory.Pattern.Pizzas.Abstract;
using AbstractFactory.Pattern.Stores.Abstract;

namespace AbstractFactory.Pattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory) { name = "New York Style Chesse Pizza." };
            }

            return pizza;
        }
    }
}
