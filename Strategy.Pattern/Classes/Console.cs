using Strategy.Pattern.Interfaces;
using System;

namespace Strategy.Pattern.Classes
{
    public class Console : IOutput
    {
        public void Print()
        {
            System.Console.WriteLine("This is the console output.");
        }
    }
}
