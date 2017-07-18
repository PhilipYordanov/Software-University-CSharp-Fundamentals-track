using _01.Vehicles.VehicleModels;

namespace _01.Vehicles.VehicleFactory
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle(string vehicle, double fuelQuantity, double fuelConsumptionPerKm)
        {
            switch (vehicle)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumptionPerKm);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumptionPerKm);
                default:
                    return null;
            }
        }
    }
}