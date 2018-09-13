using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Pattern.Interfaces;

namespace Command.Pattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.On();
        }
    }
}
