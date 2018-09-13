using AbstractFactory.Pattern.Factories.Interfaces;
using AbstractFactory.Pattern.Ingredients;
using AbstractFactory.Pattern.Ingredients.Interfaces;

namespace AbstractFactory.Pattern.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateChesse()
        {
            return new ReginatoCheese();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
