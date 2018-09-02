using Strategy.Pattern.Interfaces;
using System;

namespace Strategy.Pattern.Classes
{
    public class Printer : IOutput
    {
        public void Print()
        {
            System.Console.WriteLine("This is the printer output.");
        }
    }
}
