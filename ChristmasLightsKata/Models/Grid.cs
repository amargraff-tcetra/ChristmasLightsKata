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
        public int OnCount 
        { 
            get 
            { 
                var result = 0;
                for (var w = 0; w <= Width; w++)
                {
                    for (var h = 0; h <= Height; h++)
                    {
                        if (Lights[w, h].On) result++; 
                    }
                }
                return result;
            }
        }
        public int OffCount 
        { 
            get 
            { 
                return Count - OnCount; 
            }
        }
        public readonly int Count;

        public Grid(int i, int j)
        {
            Count = i * j;
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

        public void TurnOn((int x,int y) start, (int x,int y) end)
        {
            for (var w = start.x; w <= end.x; w++)
            {
                for (int h = start.y; h <= end.y; h++)
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

        public void Toggle()
        {
            for (int w = 0; w <= Width; w++)
            {
                for (int h = 0; h <= Height; h++)
                {
                    Lights[w, h].Toggle();
                }
            }
        }
    }
}
