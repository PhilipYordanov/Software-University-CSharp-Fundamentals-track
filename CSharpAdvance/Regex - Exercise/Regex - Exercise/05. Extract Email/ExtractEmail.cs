using System;
using System.Text.RegularExpressions;

public class ExtractEmail
{
    public static void Main()
    {
        // var pattern = @"(\w+)?.(\w+)@(\w+)(\.)\w+((\.)\w+)?";
        var pattern = @"(( [A-Za-z0-9][\w.-]+)@[a-z][a-z.-]+\.([a-z]+))";

        var text = Console.ReadLine();

        var matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}