using Strategy.Pattern.Interfaces;
using System;

namespace Strategy.Pattern.Classes
{
    public class Output
    {
        public IOutput _output;

        public Output(IOutput output)
        {
            this._output = output;
        }

        public void Print()
        {
            _output.Print();
        }
    }
}
