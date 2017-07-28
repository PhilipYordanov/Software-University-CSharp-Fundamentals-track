using System;
using System.Linq;
using _04.Froggy;

public class StartUp
{
    public static void Main()
    {
        var lake = new Lake<int>(Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray());
        
        Console.WriteLine(lake.ForEach());
    }
}