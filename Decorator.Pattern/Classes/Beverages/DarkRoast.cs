namespace Decorator.Pattern.Classes.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            base.Description = "DarkRoast";
        }

        public override decimal Cost()
        {
            return 1M;
        }

        public override string GetDescription()
        {
            return base.Description;
        }
    }
}
