using System;
using System.Collections.Generic;

namespace _07.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        public double distance;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumption, double distance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.distance = 0;
        }

        public void CarTravelling(double km)
        {
            if (this.FuelAmount / this.FuelConsumption >= km)
            {
                this.distance += km;
                this.FuelAmount -= this.FuelConsumption * km;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
