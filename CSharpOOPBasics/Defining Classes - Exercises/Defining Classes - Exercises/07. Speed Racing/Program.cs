using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCar = Console.ReadLine()
                    .Split();

                cars.Add(new Car(currentCar[0], double.Parse(currentCar[1]), double.Parse(currentCar[2]), 0));
            }
            string brum;

            var sb = new List<string>();

            while ((brum = Console.ReadLine()) != "End")
            {
                var tokens = brum.Split();
                var model = tokens[1];
                var distanceTraveled = double.Parse(tokens[2]);
                cars.First(x => x.Model == model).CarTravelling(distanceTraveled);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.distance:F0}");
            }
        }
    }
}
