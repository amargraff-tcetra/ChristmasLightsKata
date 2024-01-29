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
        private int _brightness { get; set; }
        /// <summary>
        /// Non-negative integer that represents the brightness of the light.
        /// </summary>
        public int Brightness
        {
            get => _brightness;
            set
            {
                _brightness = value < 0 ? 0 : value;
            }
        }

        public Light() 
        {
            _brightness = 0;
        }

        /// <summary>
        /// Toggles the on/not On status of a light.
        /// </summary>
        public void Toggle()
        {
            On = !On;
            Brightness += 2;
        }

        /// <summary>
        /// Sets the On property to false.
        /// </summary>
        public void TurnOff()
        {
            On = false;
            Brightness -= 1;
        }

        /// <summary>
        /// Sets the On property to true.
        /// </summary>
        public void TurnOn()
        {
            On = true;
            Brightness += 1;
        }
    }
}
