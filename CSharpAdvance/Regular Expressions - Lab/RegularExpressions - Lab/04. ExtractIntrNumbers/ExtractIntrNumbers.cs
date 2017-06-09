using System;
using System.Text.RegularExpressions;

public class ExtractIntrNumbers
{
    public static void Main()
    {
        var pattern = @"(\d+)";

        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}