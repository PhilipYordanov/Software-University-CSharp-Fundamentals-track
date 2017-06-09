using System;
using System.Text.RegularExpressions;

public class MatchCount
{
    public static void Main()
    {
        var pattern = Console.ReadLine();

        var text = Console.ReadLine();

        var mateches = Regex.Matches(text, pattern).Count;

        Console.WriteLine(mateches);
    }
}