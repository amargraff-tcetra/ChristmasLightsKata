using ChristmasLightsKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ChristmasLightsKata
{
    public class ComplexGridTests
    {

        [Fact]
        public void TurnOnRowOfLights()
        {
            var grid = new Grid(3, 3); //3x3 grid of lights
            grid.TurnOn((0,0),(2,0));//Turns on first row of lights
            for (var w = 0; w <= grid.Width; w++)
            {
                for (var h = 0; h <= grid.Height; h++)
                {
                    if (h == 0)
                    {
                        Assert.True(grid.Lights[w, h].On);
                    }
                    else
                    {
                        Assert.False(grid.Lights[w, h].On);
                    }
                }
            }
        }
        
        [Fact]
        public void TurnOnSingleLight()
        {
            var grid = new Grid(3, 3); //3x3 grid of lights
            grid.TurnOn((1,1),(1,1));//Turns on center light
            Assert.True(grid.OnCount == 1);
        }
        
        [Fact]
        public void TurnOffSingleLight()
        {
            var grid = new Grid(3, 3); //3x3 grid of lights
            grid.TurnOn((1,1),(1,1));//Turns on center light
            grid.Toggle();
            Assert.True(grid.OffCount == 1);
        }
    }
}
