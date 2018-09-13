using AbstractFactory.Pattern.Factories.Interfaces;
using AbstractFactory.Pattern.Pizzas.Abstract;

namespace AbstractFactory.Pattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            base.Sauce = _ingredientFactory.CreateSauce();
            base.Chesse = _ingredientFactory.CreateChesse();
        }
    }
}
