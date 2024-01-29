using ChristmasLightsKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata
{
    public class GridTests
    {
        [Fact]
        public void NonemptyGridOfLights()
        {
            var grid = new Grid(1,1);
            Assert.True(grid.Lights[0,0] != null);
        }

        [Fact]
        public void TurnOnGridOfLights()
        {
            var width = 2;
            var height = 2;
            var grid = new Grid(width, height);
            grid.TurnOn();
            for (var w = 0; w <= width - 1; w++)
            {
                for (var h = 0; h <= height - 1; h++)
                {
                    Assert.True(grid.Lights[w,h].On);
                }
            }
        }

        [Fact]
        public void TurnOffGridOfLights()
        {
            var width = 2;
            var height = 2;
            var grid = new Grid(width, height);
            grid.TurnOff();
            for (var w = 0; w <= width - 1; w++)
            {
                for (var h = 0; h <= height - 1; h++)
                {
                    Assert.False(grid.Lights[w,h].On);
                }
            }
        }

        [Fact]
        public void ToggleGridOfLights()
        {
            var width = 2;
            var height = 2;
            var grid = new Grid(width, height);
            grid.Toggle();
            for (var w = 0; w <= width - 1; w++)
            {
                for (var h = 0; h <= height - 1; h++)
                {
                    Assert.True(grid.Lights[w,h].On);
                }
            }
        }
    }
}
