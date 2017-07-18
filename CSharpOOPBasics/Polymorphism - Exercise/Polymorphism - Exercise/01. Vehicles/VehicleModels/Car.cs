using _01.Vehicles.Constants;

namespace _01.Vehicles.VehicleModels
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm)
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm +=  VehicleConstants.CarAirConditionerConsumption;
        }
    }
}