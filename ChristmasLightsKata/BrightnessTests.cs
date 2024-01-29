using ChristmasLightsKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata
{
    public class BrightnessTests
    {
        [Fact]
        public void DecreaseBrightness()
        {
            var light = new Light();
            light.Brightness = 3;
            light.TurnOff();
            Assert.Equal(2, light.Brightness);
        }

        [Fact]
        public void NonNegativeBrightness()
        {
            var light = new Light();
            light.TurnOff();
            Assert.Equal(0, light.Brightness);
        }

        [Fact]
        public void TotalBrightness() 
        {
            var grid = new Grid(3,3);
            grid.TurnOn();
            Assert.Equal(9, grid.TotalBrightness);
        }
    }
}
