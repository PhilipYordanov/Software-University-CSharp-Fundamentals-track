using _01.Vehicles.Constants;

namespace _01.Vehicles.VehicleModels
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm += VehicleConstants.TruckAirConditionerConsumption;
        }
    }
}