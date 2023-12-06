using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Airplane : Vehicle
    {
        public Airplane():base() { }
        public int EngineCount { get; set; }
        public override void CalculateFuelCost()
        {
            Console.WriteLine("Calculating fuel cost for the airplane...");
        }
    }
}
