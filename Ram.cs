using System;

namespace intro_interfaces {
    public class Ram : IGasPowered { // Gas powered truck
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank () {
            Console.WriteLine ("Adding fuel to the Ram.");
        }
    }
}