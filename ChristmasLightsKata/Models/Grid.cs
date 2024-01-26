using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    public class Grid
    {
        public Grid(int i, int j)
        {
            Lights = new Light[i+1,j+1];
            for (int w = 0; w <= i; w++)
            {
                for(int h = 0; h <= j; h++)
                {
                    Lights[i,j] = new Light();
                }
            }
        }

        public Light[,] Lights { get; set; }
    }
}
