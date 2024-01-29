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
            var count = Instructions.ExecuteInstructions();
            Assert.Equal(230022, count);
        }
    }
}
