using System;

namespace intro_interfaces {
    public class Tesla : IElectricPowered { // Electric car
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery () 
        {
            Console.WriteLine("Charging Tesla Battery.");
        }
    }
}