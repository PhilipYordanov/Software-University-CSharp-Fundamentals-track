using System;
using System.Linq;

public class UpperStrings
{
    public static void Main()
    {
        Console.ReadLine()
            .Split()
            .ToList()
            .ForEach(x => Console.Write(x.ToUpper() + " "));
    }
}