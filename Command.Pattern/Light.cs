using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Pattern
{
    public class Light
    {
        public string State { get; set; }

        public Light()
        {
            this.State = "Off";
        }

        public void On()
        {
            this.State = "On";
        }
        public void Off()
        {
            this.State = "Off";
        }
    }
}
