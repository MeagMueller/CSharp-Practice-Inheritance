using System;
using System.Collections.Generic;

namespace Custom_Colors_and_Sounds
{
    class Tesla
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging...");
        }
    }
}