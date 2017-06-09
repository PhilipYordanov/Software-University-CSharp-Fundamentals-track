using System;
using System.Text.RegularExpressions;

public class ExtractTags
{
    public static void Main()
    {
        var pattern = @"<.+?>";

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var matches = Regex.Matches(input, pattern);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}