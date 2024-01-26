using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    public class Light
    {
        public bool On { get; set; }

        public void Toggle()
        {
            On = !On;
        }

        public void TurnOff()
        {
            On = false;
        }

        public void TurnOn()
        {
            On = true;
        }
    }
}
