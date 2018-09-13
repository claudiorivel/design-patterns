using AbstractFactory.Pattern.Factories.Interfaces;
using AbstractFactory.Pattern.Ingredients;
using AbstractFactory.Pattern.Ingredients.Interfaces;

namespace AbstractFactory.Pattern.Factories
{
    public class ChicagoPizzaIgredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateChesse()
        {
            return new MozzarellaCheese();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

    }
}
