using System;
using System.Collections.Generic;

namespace Custom_Colors_and_Sounds
{
    public class Cessna
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Refueling...");
        }
    }
}