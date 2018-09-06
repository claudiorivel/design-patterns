using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Pattern.Abstract;

namespace Factory.Pattern
{
    public class ChicagoStyleChessePizza : Pizza
    {
        public ChicagoStyleChessePizza()
        {
            base.name = "Chicago Style Deep Dish Cheese Pizza";

        }
    }
}
