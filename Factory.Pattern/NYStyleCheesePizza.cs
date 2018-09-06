using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Pattern.Abstract;

namespace Factory.Pattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            base.name = "NY Style Sauce and Cheese Pizza";

        }
    }
}
