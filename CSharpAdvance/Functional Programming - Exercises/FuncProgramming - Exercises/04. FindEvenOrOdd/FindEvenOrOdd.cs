using System;
using System.Collections.Generic;
using System.Linq;

public class FindEvenOrOdd
{
    public static void Main()
    {
        var rangeBorders = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var startBorder = rangeBorders[0];
        var endBorder = rangeBorders[1];

        var numbers = Enumerable
            .Range(startBorder, endBorder - startBorder + 1);

        var command = Console.ReadLine();

        Predicate<int> isEven = n => n % 2 == 0;

        PrintChoosenNumbers(numbers, command, isEven);
    }

    private static void PrintChoosenNumbers(IEnumerable<int> numbers, string command, Predicate<int> isEven)
    {
        List<int> result = new List<int>();

        foreach (var number in numbers)
        {
            if (isEven(number) && command == "even")
            {
                result.Add(number);
            }
            else if (!isEven(number) && command == "odd")
            {
                result.Add(number);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}