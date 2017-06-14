using System;
using System.Linq;

public class SumNumbers
{
    public static void Main()
    {
        var line = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        Console.WriteLine(line.Sum());
        Console.WriteLine(line.Count());
    }
}