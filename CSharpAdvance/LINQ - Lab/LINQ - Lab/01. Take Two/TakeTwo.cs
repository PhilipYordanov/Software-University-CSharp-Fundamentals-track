using System;
using System.Linq;

public class TakeTwo
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Distinct()
            .Where(x => x >= 10 && x <= 20)
            .Take(2)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}