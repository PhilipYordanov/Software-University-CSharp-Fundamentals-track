using System;
using System.Linq;

public class ReverseExclude
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse);
        var num = int.Parse(Console.ReadLine());
        var result = numbers
            .Reverse()
            .ToArray()
            .Where(x => x % num != 0)
            .ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}