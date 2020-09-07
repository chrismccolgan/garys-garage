using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooooowwww!");
        }
    }

}