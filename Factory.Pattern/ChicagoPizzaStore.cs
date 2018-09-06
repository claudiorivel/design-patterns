using Factory.Pattern.Abstract;

namespace Factory.Pattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleChessePizza();
            }
            //else if (item.Equals("veggie"))
            //{
            //    return new NYStyleVeggiePizza();
            //} else if (item.Equals("clam"))
            //{
            //    return new NYStyleClamPizza();
            //} else if (item.Equals("pepperoni"))
            //{
            //    return new NYStylePepperoniPizza();
            //} else
                return null;
        }
    }
}
