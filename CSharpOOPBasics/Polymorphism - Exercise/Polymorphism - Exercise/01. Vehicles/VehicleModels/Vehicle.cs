namespace _01.Vehicles.VehicleModels
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;

        internal Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumptionPerKm
        {
            get
            {
                return this.fuelConsumptionPerKm;
            }
             set
            {
                this.fuelConsumptionPerKm = value;
            }
        }
    }
}