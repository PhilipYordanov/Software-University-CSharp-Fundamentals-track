using System;
using System.Text.RegularExpressions;

public class ExtractQuotations
{
    public static void Main()
    {
        string pattern = @"(""|')(.+?)\1";

        var text = Console.ReadLine();

        var matchGroups = Regex.Matches(text, pattern);

        foreach (Match match in matchGroups)
        {
            Console.WriteLine(match.Groups[2]);
        }
    }
}