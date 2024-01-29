using ChristmasLightsKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata
{
    public class SantaInstructionTests
    {
        public SantaInstructions Instructions { get; set; }

        public SantaInstructionTests()
        {
            Instructions = new SantaInstructions();
        }

        [Fact]
        public void LightCount()
        {
            Instructions.Execute();
            var onCount = Instructions.GetOnCount();
            Assert.Equal(230022, onCount);
        }

        [Fact]
        public void TotalBrightnessCount()
        {
            Instructions.Execute();
            var totalBrightness = Instructions.GetTotalBrightness();
            Assert.Equal(539560, totalBrightness);
        }
    }
}
