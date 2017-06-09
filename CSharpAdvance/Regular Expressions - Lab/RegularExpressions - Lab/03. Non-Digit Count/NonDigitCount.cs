using System;
using System.Text.RegularExpressions;

public class NonDigitCount
{
    public static void Main()
    {
        var pattern = @"[\D]";

        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern).Count;

        Console.WriteLine($"Non-digits: {matches}");
    }
}