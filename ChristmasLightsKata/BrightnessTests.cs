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

        [Fact]
        public void ToggleAddsBrightness() 
        {
            var grid = new Grid(3, 3);
            grid.Toggle();
            Assert.Equal(18, grid.TotalBrightness);
        }

        [Fact]
        public void Example1()
        {
            var grid = new Grid(1000,1000);
            grid.TurnOn((0,0),(0,0));
            Assert.Equal(1, grid.TotalBrightness);
        }

        [Fact]
        public void Example2()
        {
            var grid = new Grid(1000, 1000);
            grid.Toggle((0, 0), (999, 999));
            Assert.Equal(2 * 1000 * 1000, grid.TotalBrightness);
        }
    }
}
