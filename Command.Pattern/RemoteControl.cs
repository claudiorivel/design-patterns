using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Pattern.Commands;
using Command.Pattern.Interfaces;

namespace Command.Pattern
{
    public class RemoteControl
    {
        private ICommand[] OnCommands { get; set; }
        private ICommand[] OffCommands { get; set; }

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            for (int i = 0; i < 7; i++)
            {
                OnCommands[i] = new NoCommand();
                OffCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            OnCommands[slot].Execute();
        }

        public void OffButtonPressed(int slot)
        {
            OffCommands[slot].Execute();
        }
    }
}
