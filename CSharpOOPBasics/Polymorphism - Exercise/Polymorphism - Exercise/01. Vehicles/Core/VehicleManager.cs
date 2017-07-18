using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01.Vehicles.VehicleModels;

namespace _01.Vehicles.Core
{
    public class VehicleManager
    {
        private Dictionary<string, Vehicle> vehicles;

        public VehicleManager()
        {
            this.vehicles = new Dictionary<string, Vehicle>();
        }

        public void CreateCar(List<string> arguments)
        {
            var fuelQuantity = double.Parse(arguments[0]);
            var fuelConsumptionPerKm = double.Parse(arguments[1]);
            vehicles.Add("car", new Car(fuelQuantity, fuelConsumptionPerKm));
        }

        public void CreateTruck(List<string> arguments)
        {
            var fuelQuantity = double.Parse(arguments[0]);
            var fuelConsumptionPerKm = double.Parse(arguments[1]);
            vehicles.Add("truck", new Truck(fuelQuantity, fuelConsumptionPerKm));
        }

        public string DriveCar(List<string> commandArgs)
        {
            var car = vehicles.FirstOrDefault(x => x.Key == "car").Value;
            var drivenDistance = car.FuelConsumptionPerKm * double.Parse(commandArgs[0]);
            if (car.FuelQuantity > drivenDistance)
            {
                this.vehicles["car"].FuelQuantity -= drivenDistance;
                return $"Car travelled {commandArgs[0]} km";
            }
            else
            {
                return "Car needs refueling";
            }
        }

        public string DriveTruck(List<string> commandArgs)
        {
            var truck = vehicles.FirstOrDefault(x => x.Key == "truck").Value;
            var drivenDistance = truck.FuelConsumptionPerKm * double.Parse(commandArgs[0]);
            if (truck.FuelQuantity > drivenDistance)
            {
                this.vehicles["truck"].FuelQuantity -= drivenDistance;
                return $"Truck travelled {commandArgs[0]} km";
            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public void RefuelCar(List<string> commandArgs)
        {
            this.vehicles["car"].FuelQuantity += double.Parse(commandArgs[0]);
        }

        public void RefuelTruck(List<string> commandArgs)
        {
            this.vehicles["truck"].FuelQuantity += double.Parse(commandArgs[0]);
        }

        public string PrintFuel()
        {
            var sb = new StringBuilder();
            foreach (var vehicle in vehicles)
            {
                sb.AppendLine($"{vehicle.Value.GetType().Name}: {vehicle.Value.FuelQuantity:F2}");
            }
            return sb.ToString().Trim();
        }
    }
}