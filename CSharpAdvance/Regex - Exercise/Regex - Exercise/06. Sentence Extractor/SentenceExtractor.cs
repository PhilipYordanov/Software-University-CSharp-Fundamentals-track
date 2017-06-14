using System;
using System.Text.RegularExpressions;

public class SentenceExtractor
{
    public static void Main()
    {
        var patternWord = Console.ReadLine();

        var pattern = $@"[^.?!]*(?<=[.?\s!]){patternWord}(?=[\s.?!])[^.?!]*[.?!]";
        var text = Console.ReadLine();
        var matches = Regex.Matches(text, pattern);

        foreach (Match mat in matches)
        {
            Console.WriteLine(mat);
        }
    }
}