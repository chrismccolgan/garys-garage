namespace Garage
{
    public interface IElectricVehicle
    {
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}