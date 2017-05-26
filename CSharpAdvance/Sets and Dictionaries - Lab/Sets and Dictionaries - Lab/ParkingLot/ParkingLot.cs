using System;
using System.Collections.Generic;

public class ParkingLot
{
    public static void Main()
    {
        var input = Console.ReadLine();

        SortedSet<string> parking = new SortedSet<string>();

        while (input != "END")
        {
            var tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];
            var carNumber = tokens[1];

            if (command == "IN")
            {
                parking.Add(carNumber);
            }
            else
            {
                if (parking.Contains(carNumber))
                {
                    parking.Remove(carNumber);
                }
            }

            input = Console.ReadLine();
        }

        if (parking.Count == 0)
        {
            Console.WriteLine("Parking Lot is Empty");
        }
        else
        {
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}