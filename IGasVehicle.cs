namespace Garage
{
    public interface IGasVehicle
    {
        double CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}