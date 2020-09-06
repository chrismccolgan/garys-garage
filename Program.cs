using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgundy";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";

            Ram truck = new Ram();
            truck.MainColor = "Silver";

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
        }
    }
}