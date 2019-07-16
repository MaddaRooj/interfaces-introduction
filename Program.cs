using System;
using System.Collections.Generic;

namespace intro_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ();
            Zero fx = new Zero ();
            Tesla modelS = new Tesla ();

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>()
            {
                fxs, fx, modelS
            };
            electricVehicles.ForEach(ev => ev.ChargeBattery());

            Ram ram = new Ram ();
            Cessna cessna = new Cessna ();

            List<IGasPowered> gasVehicles = new List<IGasPowered>()
            {
                ram, cessna
            };
            gasVehicles.ForEach(gv => gv.RefuelTank());

        }
    }
}
