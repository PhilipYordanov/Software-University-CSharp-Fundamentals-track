using System;
using System.Linq;

public class PredicatNames
{
    public static void Main()
    {
        var len = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split().ToArray();

        var result = names
            .Where(x => x.Length <= len)
            .ToArray();
        Console.WriteLine(string.Join("\r\n", result));
    }
}