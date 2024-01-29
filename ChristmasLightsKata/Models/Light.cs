using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    /// <summary>
    /// A single light that can be On or Not On.
    /// </summary>
    public class Light
    {
        /// <summary>
        /// When true the light is on, when false the light is not On.
        /// </summary>
        public bool On { get; set; }

        /// <summary>
        /// Toggles the on/not On status of a light.
        /// </summary>
        public void Toggle()
        {
            On = !On;
        }

        /// <summary>
        /// Sets the On property to false.
        /// </summary>
        public void TurnOff()
        {
            On = false;
        }

        /// <summary>
        /// Sets the On property to true.
        /// </summary>
        public void TurnOn()
        {
            On = true;
        }
    }
}
