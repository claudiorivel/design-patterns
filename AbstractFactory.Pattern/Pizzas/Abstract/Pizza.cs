using System.Collections.Generic;
using AbstractFactory.Pattern.Ingredients.Interfaces;

namespace AbstractFactory.Pattern.Pizzas.Abstract
{
    public abstract class Pizza
    {
        public string name;
        public ICheese Chesse { get; set; }
        public ISauce Sauce { get; set; }
        List<string> toppings = new List<string>();

        public abstract void Prepare();

        public void Bake()
        {
            // baking
        }

        public void Cut()
        {
            // cutting
        }

        public void Box()
        {
            // boxing
        }

        public string GetName()
        {
            return name;
        }

    }
}
