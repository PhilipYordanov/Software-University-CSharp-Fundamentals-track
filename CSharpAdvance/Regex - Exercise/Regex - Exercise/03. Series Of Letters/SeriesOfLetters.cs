using System;
using System.Text;
using System.Text.RegularExpressions;

public class SeriesOfLetters
{
    public static void Main()
    {
        var pattern = @"([\D])\1*";

        var input = Console.ReadLine();

        var mateches = Regex.Matches(input, pattern);

        var sb = new StringBuilder();

        foreach (Match match in mateches)
        {
            sb.Append(match.Groups[1].Value);
        }

        Console.WriteLine(sb);
    }
}