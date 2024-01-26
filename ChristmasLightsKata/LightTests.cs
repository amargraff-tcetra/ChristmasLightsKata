using ChristmasLightsKata.Models;

namespace ChristmasLightsKata
{
    public class LightTests
    {
        [Fact]
        public void LightsStartOff()
        {
            var light = new Light();

            Assert.True(!light.On);
        }
    }
}