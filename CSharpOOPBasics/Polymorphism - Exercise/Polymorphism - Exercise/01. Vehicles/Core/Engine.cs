using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _01.Vehicles.Core
{
    using System;
    using _01.Vehicles.Constants;

    public class Engine
    {
        private VehicleManager vehicleManager;

        public Engine()
        {
            this.vehicleManager = new VehicleManager();
        }

        public void Run()
        {
            List<string> arguments;

            for (int i = 0; i < VehicleConstants.NumberOfVehicles; i++)
            {
                arguments = Console.ReadLine()
                    .Split()
                    .ToList();
                var vehicle = arguments[0];
                arguments.RemoveAt(0);

                switch (vehicle)
                {
                    case "Car":
                        this.vehicleManager.CreateCar(arguments);
                        break;
                    case "Truck":
                        this.vehicleManager.CreateTruck(arguments);
                        break;
                }
            }

            var numberOfCommands = int.Parse(Console.ReadLine());
            List<string> commandArgs;
            
            for (int i = 0; i < numberOfCommands; i++)
            {
                commandArgs = Console.ReadLine()
                    .Split()
                    .ToList();
                var command = commandArgs[0];
                commandArgs.RemoveAt(0);
                switch (command)
                {
                    case "Drive":
                        var vechileToDrive = commandArgs[0];
                        commandArgs.RemoveAt(0);
                        switch (vechileToDrive)
                        {
                            case "Car":
                                Console.WriteLine(this.vehicleManager.DriveCar(commandArgs));
                                break;
                            case "Truck":
                                Console.WriteLine(this.vehicleManager.DriveTruck(commandArgs));
                                break;
                        }
                        break;
                    case "Refuel":
                        var vechileToRefuel = commandArgs[0];
                        commandArgs.RemoveAt(0);
                        switch (vechileToRefuel)
                        {
                            case "Car":
                                this.vehicleManager.RefuelCar(commandArgs);
                                break;
                            case "Truck":
                                this.vehicleManager.RefuelTruck(commandArgs);
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(this.vehicleManager.PrintFuel());
        }
    }
}