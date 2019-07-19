using System.Collections.Generic;

namespace intro_interfaces
{
    public class BatteryStation : IStation<IElectricPowered>
    {
        public int Capacity { get; set; }

        public void Refuel(List<IElectricPowered> vehicles)
        {
            System.Console.WriteLine("Battery Station Refuel Log: ");
            foreach(var vehicle in vehicles)
            {
                try
                {

                System.Console.WriteLine($"Battery station now accepting {vehicle.ToString().Split(".")[1]}");
                }
                catch
                {
                    System.Console.WriteLine("Cannot accept gas vehicles.");
                }
            }
        }
    }
}