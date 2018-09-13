using AbstractFactory.Pattern.Ingredients.Interfaces;

namespace AbstractFactory.Pattern.Factories.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        ICheese CreateChesse();
        ISauce CreateSauce();
    }
}
