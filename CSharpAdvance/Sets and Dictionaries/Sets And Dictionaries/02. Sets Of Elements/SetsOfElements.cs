using System;
using System.Collections.Generic;
using System.Linq;

public class SetsOfElements
{
    public static void Main()
    {
        var tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        var first = tokens[0];
        var second = tokens[1];

        SortedSet<int> firstSet = new SortedSet<int>();
        SortedSet<int> secondSet = new SortedSet<int>();

        for (int i = 0; i < first; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            firstSet.Add(currentNumber);
        }

        for (int i = 0; i < second; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            secondSet.Add(currentNumber);
        }

        var resultSet = firstSet.Intersect(secondSet);

        foreach (var item in resultSet)
        {
            Console.Write(item + " ");
        }
    }
}
