using System;

namespace intro_interfaces
{
    public class Zero : IElectricPowered
    { // Electric motorcycle
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery() 
        { 
            Console.WriteLine("Charging Zero Battery.");
        }
    }
}