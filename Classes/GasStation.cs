using System.Collections.Generic;

namespace intro_interfaces
{
    public class GasStation : IStation<IGasPowered>
    {
        public int Capacity { get; set; }

        public void Refuel(List<IGasPowered> vehicles)
        {
            System.Console.WriteLine("Gas Station Refuel Log: ");
            foreach(var vehicle in vehicles)
            {
                try
                {

                System.Console.WriteLine($"Gas station now accepting {vehicle.ToString().Split(".")[1]}");
                }
                catch
                {
                    System.Console.WriteLine("Cannot accept electic vehicles.");
                }
            }
        }
    }
}