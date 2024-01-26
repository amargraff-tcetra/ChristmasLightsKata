using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    public class Grid
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Light[,] Lights { get; set; }

        public Grid(int i, int j)
        {
            Width = i - 1;
            Height = j - 1;
            Lights = new Light[i,j];
            for (int w = 0; w <= Width; w++)
            {
                for(int h = 0; h <= Height; h++)
                {
                    Lights[w,h] = new Light();
                }
            }
        }

        public void TurnOn()
        {
            for (int w = 0; w <= Width; w++)
            {
                for (int h = 0; h <= Height; h++)
                {
                    Lights[w, h].TurnOn();
                }
            }
        }

        public void TurnOff()
        {
            for (int w = 0; w <= Width; w++)
            {
                for (int h = 0; h <= Height; h++)
                {
                    Lights[w, h].TurnOff();
                }
            }
        }
    }
}
