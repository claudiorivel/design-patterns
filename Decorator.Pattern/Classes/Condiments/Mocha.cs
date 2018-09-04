namespace Decorator.Pattern.Classes.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            base.Beverage = beverage;
        }

        public override decimal Cost()
        {
            return (decimal) 0.50 + base.Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}
