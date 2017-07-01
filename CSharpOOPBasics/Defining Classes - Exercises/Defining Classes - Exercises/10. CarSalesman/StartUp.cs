namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numberOfengines = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < numberOfengines; i++)
            {
                var engineTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentEngine = new Engine(engineTokens[0], int.Parse(engineTokens[1]));

                if (engineTokens.Length > 2)
                {
                    DisplacementEfficiency(engineTokens[2], currentEngine);
                }
                if (engineTokens.Length > 3)
                {
                    DisplacementEfficiency(engineTokens[3], currentEngine);
                }

                engines.Add(currentEngine);
            }

            var numberOFCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOFCars; i++)
            {
                var carTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = carTokens[0];
                var nameOfEngineToGet = carTokens[1];
                var selectedEngine = engines
                    .Where(x => x.Model == nameOfEngineToGet)
                    .First();

                var currentCar = new Car(model, selectedEngine);
                if (carTokens.Length > 2)
                {
                    ColorWeight(carTokens[2], currentCar);
                }
                if (carTokens.Length > 3)
                {
                    ColorWeight(carTokens[3], currentCar);
                }
                cars.Add(currentCar);
            }

            Printer(cars);
        }

        private static void DisplacementEfficiency(string token, Engine currentEngine)
        {
            int testNumber;
            bool isColorOrWeight = int.TryParse(token, out testNumber);
            if (isColorOrWeight)
            {
                currentEngine.Displacement = token;
            }
            else
            {
                currentEngine.Efficiency = token;
            }
        }

        private static void Printer(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

        private static void ColorWeight(string token, Car currentCar)
        {
            int testNumber;
            bool isColorOrWeight = int.TryParse(token, out testNumber);
            if (isColorOrWeight)
            {
                currentCar.Weight = token;
            }
            else
            {
                currentCar.Color = token;
            }
        }
    }
}
