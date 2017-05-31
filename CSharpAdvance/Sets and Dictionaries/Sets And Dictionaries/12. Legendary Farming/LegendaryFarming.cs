using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var result = new Dictionary<string, int>();
        var junks = new Dictionary<string, int>();

        ResultSeed(result);

        int counter = 1;
        var mat = string.Empty;
        var quan = 0;

        while (true)
        {
            var tokens = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            ReadingAndSavingData(result, junks, ref counter, ref mat, ref quan, tokens);

            if (result["shards"] <= 0)
            {
                Console.WriteLine("Shadowmourne obtained!");
                break;
            }

            if (result["fragments"] <= 0)
            {
                Console.WriteLine("Valanyr obtained!");
                break;
            }

            if (result["motes"] <= 0)
            {
                Console.WriteLine("Dragonwrath obtained!");
                break;
            }
        }

        Dictionary<string, int> copyOfResultDictionary = CopyOfResultDictionary(result);

        PrintResult(junks, copyOfResultDictionary);
    }

    private static void ReadingAndSavingData(Dictionary<string, int> result, Dictionary<string, int> junks, ref int counter, ref string mat, ref int quan, string[] tokens)
    {
        foreach (var token in tokens)
        {
            counter++;
            ReadKeyValuePair(counter, ref mat, ref quan, token);

            if (counter % 2 == 1)
            {
                if (result.ContainsKey(mat))
                {
                    result[mat] -= quan;
                    if (result["shards"] <= 0)
                    {
                        break;
                    }

                    if (result["fragments"] <= 0)
                    {
                        break;
                    }

                    if (result["motes"] <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    if (!junks.ContainsKey(mat))
                    {
                        junks[mat] = quan;
                    }
                    else
                    {
                        junks[mat] += quan;
                    }
                }
            }
        }
    }

    private static void PrintResult(Dictionary<string, int> junks, Dictionary<string, int> copyOfResultDictionary)
    {
        foreach (var kvp in copyOfResultDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        foreach (var kvp in junks.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    private static Dictionary<string, int> CopyOfResultDictionary(Dictionary<string, int> result)
    {
        var copyOfResultDictionary = new Dictionary<string, int>();

        foreach (var kvp in result)
        {
            if (kvp.Value > 0)
            {
                var name = kvp.Key;
                var st = Math.Abs(kvp.Value - 250);
                copyOfResultDictionary.Add(name, st);
            }
            else
            {
                var name = kvp.Key;
                var st = Math.Abs(kvp.Value);
                copyOfResultDictionary.Add(name, st);
            }
        }

        return copyOfResultDictionary;
    }

    private static void ResultSeed(Dictionary<string, int> result)
    {
        result.Add("shards", 250);
        result.Add("fragments", 250);
        result.Add("motes", 250);
    }

    private static void ReadKeyValuePair(int counter, ref string mat, ref int quan, string token)
    {
        if (counter % 2 == 0)
        {
            var quantity = int.Parse(token);
            quan = quantity;
        }
        else
        {
            var material = token;
            mat = material;
        }
    }
}