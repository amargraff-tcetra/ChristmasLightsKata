using ChristmasLightsKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata
{
    public class GridTest
    {
        [Fact]
        public void NonemptyGridOfLights()
        {
            var grid = new Grid(0,0);
            Assert.True(grid.Lights[0,0] != null);
        }

    }
}
