using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasLightsKata.Models
{
    /// <summary>
    /// Class that holds a grid and execute orders for Santa's instructions
    /// </summary>
    public class SantaInstructions
    {
        /// <summary>
        /// Santa's 1,000 x 1,000 grid of lights.
        /// </summary>
        private  Grid _grid { get; set; }

        public SantaInstructions()
        {
            _grid = new Grid(1000, 1000);
        }

        /// <summary>
        /// Executes Santa's Instructions returning the number of lights On at the end of the instructions.
        /// </summary>
        /// <returns></returns>
        public void Execute()
        {
            _grid.TurnOn( (887,   9), (959, 629));
            _grid.TurnOn( (454, 398), (844, 448));
            _grid.TurnOff((539, 243), (559, 965));
            _grid.TurnOff((370, 819), (676, 868));
            _grid.TurnOff((145,  40), (370, 997));
            _grid.TurnOff((301,   3), (808, 453));
            _grid.TurnOn( (351, 678), (951, 908));
            _grid.Toggle( (720, 196), (897, 994));
            _grid.Toggle( (831, 394), (904, 860));
        }

        public int GetOnCount()
        {
            return _grid.OnCount;
        }        
        
        public int GetTotalBrightness()
        {
            return _grid.TotalBrightness;
        }
    }
}
