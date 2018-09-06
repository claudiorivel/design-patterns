using System.Collections.Generic;

namespace Factory.Pattern.Abstract
{
    public abstract class Pizza
    {
        public string name;
        private string dough;
        private string sauce;
        List<string> toppings = new List<string>();

        public void Prepare()
        {
            // preparing
        }

        public void Bake()
        {
            // baking
        }

        public void Cut()
        {
            // cutting
        }

        public void Box()
        {
            // boxing
        }

        public string GetName()
        {
            return name;
        }

    }
}
