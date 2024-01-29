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

        [Fact]
        public void TurnLightOn()
        {
            var light = new Light();
            light.TurnOn();
            Assert.True(light.On);
        }

        [Fact]
        public void TurnLightOff()
        {
            var light = new Light();
            light.TurnOff();
            Assert.False(light.On);
        }

        [Fact]
        public void ToggleLight() 
        { 
            var light = new Light();
            light.Toggle();
            Assert.True(light.On);
        }
    }
}