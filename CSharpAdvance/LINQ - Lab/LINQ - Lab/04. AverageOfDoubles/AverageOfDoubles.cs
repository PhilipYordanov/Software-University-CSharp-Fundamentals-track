using System;
using System.Linq;

public class AverageOfDoubles
{
    public static void Main()
    {
        Console.WriteLine($@"{Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .Average():f2}");
    }
}