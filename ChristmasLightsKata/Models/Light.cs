using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    internal class Light
    {
        public bool On { get; set; }

        internal void Toggle()
        {
            On = !On;
        }

        internal void TurnOff()
        {
            On = false;
        }

        internal void TurnOn()
        {
            On = true;
        }
    }
}
