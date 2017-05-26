using System;
using System.Collections.Generic;
using System.Linq;

public class CountOfSameValues
{
    public static void Main()
    {
        SortedDictionary<double, int> number_count = new SortedDictionary<double, int>();

        var arrayOfNumbers = Console.ReadLine()
            .Replace(',', '.')
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        foreach (var num in arrayOfNumbers)
        {
            if (!number_count.ContainsKey(num))
            {
                number_count[num] = 1;
            }
            else
            {
                number_count[num]++;
            }
        }

        foreach (var kvp in number_count.OrderBy(x => x.Key))
        {
            var number = kvp.Key;
            var occurrences = kvp.Value;
            Console.WriteLine($"{number} - {occurrences} times");
        }
    }
}