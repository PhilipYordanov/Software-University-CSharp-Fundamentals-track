using System;
using System.Text.RegularExpressions;

public class VowelCount
{
    public static void Main()
    {
        var pattern = @"[aAoOiIeEuUyY]";

        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern).Count;

        Console.WriteLine($"Vowels: {matches}");
    }
}