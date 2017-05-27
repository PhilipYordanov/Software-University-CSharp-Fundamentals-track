using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        string input;
        int count = 1;
        string name = string.Empty;

        Dictionary<string, long> material_quantity = new Dictionary<string, long>();

        while (true)
        {
            input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }

            count++;
            if (count % 2 == 0)
            {
                name = input;
                if (!material_quantity.ContainsKey(name))
                {
                    material_quantity[name] = 0;
                }
            }
            else
            {
                var quantity = long.Parse(input);
                material_quantity[name] += quantity;
            }
        }

        foreach (var kvp in material_quantity)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}