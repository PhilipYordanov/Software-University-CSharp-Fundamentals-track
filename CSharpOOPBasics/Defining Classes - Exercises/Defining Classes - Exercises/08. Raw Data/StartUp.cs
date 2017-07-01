namespace _08.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCarTokens = Console.ReadLine()
                    .Split();
                var currentModel = currentCarTokens[0];
                var currentEngine = new Engine(int.Parse(currentCarTokens[1]), int.Parse(currentCarTokens[2]));
                var currentCargoType = new Cargo(int.Parse(currentCarTokens[3]), currentCarTokens[4]);
                var currentTires = new List<Tires>()
                {
                    new Tires(int.Parse(currentCarTokens[6]), double.Parse(currentCarTokens[5]))
                    , new Tires(int.Parse(currentCarTokens[8]), double.Parse(currentCarTokens[7]))
                    , new Tires(int.Parse(currentCarTokens[10]), double.Parse(currentCarTokens[9]))
                    , new Tires(int.Parse(currentCarTokens[12]), double.Parse(currentCarTokens[11]))
                };
                var car = new Car(currentModel, currentEngine, currentCargoType, currentTires);
                cars.Add(car);
            }
            var carToPrint = Console.ReadLine();
            if (carToPrint == "flamable")
            {
                cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.EnginePower > 250)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Model}"));
            }
            else
            {
                cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(c => c.TiresPressure < 1))
                     .Select(m => m.Model)
                     .ToList()
                     .ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
