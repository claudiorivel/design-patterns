namespace Decorator.Pattern.Classes.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            base.Beverage = beverage;
        }

        public override decimal Cost()
        {
            return (decimal) 0.99 + this.Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }
    }
}
