using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue",
                CurrentChargePercentage = 50
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Burgundy",
                CurrentChargePercentage = 20
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                CurrentTankPercentage = 22
            };

            Ram truck = new Ram()
            {
                MainColor = "Silver",
                CurrentTankPercentage = 12
            };

            List<Vehicle> allVehicles = new List<Vehicle>()
            {
                fxs,
                modelS,
                truck,
                mx410
            };

            allVehicles.ForEach(vehicle =>
            {
                vehicle.Drive();
                vehicle.Turn("right");
                vehicle.Stop();
                Console.WriteLine();
            });

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles:");
            electricVehicles.ForEach(ev =>
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                Console.WriteLine($"{ev.CurrentChargePercentage}");
                Console.WriteLine();
            });

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                truck,
                mx410
            };

            Console.WriteLine("Gas Vehicles:");
            gasVehicles.ForEach(gv =>
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
                // This should completely refuel the gas tank
                gv.RefuelTank();
                Console.WriteLine($"{gv.CurrentTankPercentage}");
                Console.WriteLine();
            });
        }
    }
}