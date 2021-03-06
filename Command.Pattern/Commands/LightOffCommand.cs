﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Pattern.Interfaces;

namespace Command.Pattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            this._light.Off();
        }
    }
    
}
