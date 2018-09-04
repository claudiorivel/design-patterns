namespace Decorator.Pattern.Classes.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override decimal Cost()
        {
            return (decimal)0.50 + this.Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }
    }
}
