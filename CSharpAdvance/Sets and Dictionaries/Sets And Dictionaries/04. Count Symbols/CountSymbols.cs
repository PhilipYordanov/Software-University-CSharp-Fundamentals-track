using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        char[] inputString = Console.ReadLine().ToCharArray();

        SortedDictionary<char, int> symbols_count = new SortedDictionary<char, int>();

        for (int i = 0; i < inputString.Length; i++)
        {
            if (!symbols_count.ContainsKey(inputString[i]))
            {
                symbols_count[inputString[i]] = 1;
            }
            else
            {
                symbols_count[inputString[i]]++;
            }
        }

        foreach (var kvp in symbols_count)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}