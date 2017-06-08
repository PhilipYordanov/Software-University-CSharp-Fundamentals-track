using System;

public class ParseTags
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var openTag = "<upcase>";
        var closeTag = "</upcase>";

        var firstTag = input.IndexOf(openTag);
        var lastTag = input.IndexOf(closeTag);

        while (firstTag != -1 && lastTag != -1)
        {
            var text = input.Substring(firstTag, lastTag + closeTag.Length - firstTag);

            var replaced = text.Substring(openTag.Length, text.Length - closeTag.Length - openTag.Length).ToUpper();

            input = input.Replace(text, replaced);
            firstTag = input.IndexOf(openTag);
            lastTag = input.IndexOf(closeTag);
        }
        Console.WriteLine(input);
    }
}