using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
        var rightMaterials = new Dictionary<string, int>();
        rightMaterials.Add("fragments", 0);
        rightMaterials.Add("motes", 0);
        rightMaterials.Add("shards", 0);

        var junkMaterials = new Dictionary<string, int>();

        while (true)
        {
            var input = Console.ReadLine().ToLower().Split(' ');

            for (int i = 1; i <= input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (input[i] == "fragments" || input[i] == "motes" || input[i] == "shards")
                    {
                        rightMaterials[input[i]] += int.Parse(input[i - 1]);
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(input[i]))
                        {
                            junkMaterials.Add(input[i], int.Parse(input[i - 1]));
                        }
                        else
                        {
                            junkMaterials[input[i]] += int.Parse(input[i - 1]);
                        }
                    }
                }

                if (rightMaterials["shards"] >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");

                    rightMaterials["shards"] -= 250;

                    Print(rightMaterials, junkMaterials);

                    break;
                }
                else if (rightMaterials["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");

                    rightMaterials["fragments"] -= 250;

                    Print(rightMaterials, junkMaterials);

                    break;
                }
                else if (rightMaterials["motes"] >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");

                    rightMaterials["motes"] -= 250;

                    Print(rightMaterials, junkMaterials);

                    break;
                }
            }
            break;
        }
    }

    public static void Print(Dictionary<string, int> rightMaterials, Dictionary<string, int> junkMaterials)
    {
        foreach (var material in rightMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }

        foreach (var junk in junkMaterials.OrderBy(j => j.Key))
        {
            Console.WriteLine($"{junk.Key}: {junk.Value}");
        }
    }
}