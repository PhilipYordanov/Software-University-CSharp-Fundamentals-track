using System;
using System.Linq;

public class KnightsOfHonor
{
    public static void Main()
    {
        var names = Console.ReadLine()
            .Split();

        Action<string> print = str => Console.WriteLine(str);
        Action<string> addPrefix = str => Console.WriteLine("Sir " + str);
        PrintAllNames(names, addPrefix);
    }

    private static void PrintAllNames(string[] names, Action<string> print)
    {
        foreach (var name in names)
        {
            print(name);
        }
    }
}