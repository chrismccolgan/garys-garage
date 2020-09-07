using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Zzzzzoooooommm!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }

    }
}