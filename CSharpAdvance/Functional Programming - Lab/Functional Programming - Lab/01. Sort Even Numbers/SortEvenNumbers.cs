using System;
using System.Linq;

public class SortEvenNumbers
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Where(x => x % 2 == 0)
            .ToArray()
            .OrderBy(x => x)));
    }
}