using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    public class Grid
    {
        /// <summary>
        /// Zero based x dimension number of lights in grid.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Zero based y dimension number of lights in grid.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Two-dimensional array of Light object.
        /// </summary>
        public Light[,] Lights { get; set; }
        /// <summary>
        /// Count of lights currently On in the grid. 
        /// </summary>
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
        /// <summary>
        /// Count of lights currently not On in the grid
        /// </summary>
        public int OffCount 
        { 
            get 
            { 
                return Count - OnCount; 
            }
        }
        /// <summary>
        /// The number of lights in the grid.
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// The sum of all the Brightnesses of the lights in the grid.
        /// </summary>
        public int TotalBrightness { 
            get 
            {
                var result = 0;
                for (var w = 0; w <= Width; w++)
                {
                    for (var h = 0; h <= Height; h++)
                    {
                        result += Lights[w, h].Brightness;
                    }
                }
                return result;
            } 
        }




        /// <summary>
        /// Grid is a two-dimensional array of lights.
        /// </summary>
        /// <param name="i">Non-zero based x dimension light count</param>
        /// <param name="j">Non-zero based y dimension light count</param>
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
        /// <summary>
        /// Turns On every light in the grid
        /// </summary>
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

        /// <summary>
        /// Turns On specified consecutive lights.
        /// </summary>
        /// <param name="start">Starting zero based light position</param>
        /// <param name="end">Ending zero based light position</param>
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

        /// <summary>
        /// Turn every light in the grid to not On.
        /// </summary>
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

        /// <summary>
        /// Turns specified consecutive lights to not On.
        /// </summary>
        /// <param name="start">Starting zero based light position</param>
        /// <param name="end">Ending zero based light position</param>
        public void TurnOff((int x, int y) start, (int x, int y) end)
        {
            for (var w = start.x; w <= end.x; w++)
            {
                for (int h = start.y; h <= end.y; h++)
                {
                    Lights[w, h].TurnOff();
                }
            }
        }

        /// <summary>
        /// Toggles every light in the grid
        /// </summary>
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

        /// <summary>
        /// Toggles specified consecutive lights.
        /// </summary>
        /// <param name="start">Starting zero based light position</param>
        /// <param name="end">Ending zero based light position</param>
        public void Toggle((int x, int y) start, (int x, int y) end)
        {
            for (var w = start.x; w <= end.x; w++)
            {
                for (int h = start.y; h <= end.y; h++)
                {
                    Lights[w, h].Toggle();
                }
            }
        }
    }
}
