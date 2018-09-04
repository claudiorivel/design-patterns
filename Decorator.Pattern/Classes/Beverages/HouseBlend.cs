using System;
using Decorator.Pattern.Classes.Condiments;

namespace Decorator.Pattern.Classes.Beverages
{
    public class HouseBlend : Beverage
    {
        //private string Description { get; set; }
        public HouseBlend()
        {
            Description = "HouseBlend";
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
