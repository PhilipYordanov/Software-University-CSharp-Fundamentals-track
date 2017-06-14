using System;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        var pattern = @"(<a\s)(href=)(""|')(.*)(\3)(>)(.*)(<\/a>)";
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var match = Regex.Match(input, pattern);

            var replaced = Regex.Replace(input, pattern,
#pragma warning disable SA1117 // Parameters must be on same line or separate lines
                m => m.Groups[1].Value.Replace(m.Groups[1].Value, "[URL ")
                + m.Groups[2]
                + m.Groups[3].Value
                + m.Groups[4]
                + m.Groups[5].Value
                + m.Groups[6].Value.Replace(m.Groups[6].Value, "]")
                + m.Groups[7]
                + m.Groups[8].Value.Replace(m.Groups[8].Value, "[/URL]"));
#pragma warning restore SA1117 // Parameters must be on same line or separate lines

            if (match.Success)
            {
                Console.WriteLine(replaced);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}