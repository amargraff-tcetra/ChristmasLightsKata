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
            Assert.Equal(1, grid?.OnCount);
        }
        
        [Fact]
        public void TurnOffSingleLight()
        {
            var grid = new Grid(3, 3); //3x3 grid of lights
            grid.TurnOn((1,1),(1,1));//Turns on center light
            grid.Toggle();
            Assert.Equal(1, grid?.OffCount);
        }

        [Fact]
        public void Example1()
        {
            var grid = new Grid(1000, 1000);
            grid.TurnOn((0, 0), (999, 999));
            Assert.Equal(1000 * 1000, grid?.OnCount);
        }

        [Fact]
        public void Example2()
        {
            var grid = new Grid(1000, 1000);
            grid.Toggle((0, 0), (999, 0));
            Assert.Equal(1000, grid?.OnCount);
        }

        [Fact]
        public void Example3()
        {
            var grid = new Grid(1000, 1000);
            grid.TurnOn();
            grid.TurnOff((499, 499), (500, 500));
            Assert.Equal(4, grid?.OffCount);
        }
    }
}
