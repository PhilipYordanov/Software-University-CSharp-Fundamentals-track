using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var searchString = Console.ReadLine();
        var counter = 0;
        int i = 0;

        while ((i = text.IndexOf(searchString, i, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            if (searchString.Length == 1)
            {
                i += searchString.Length;
                counter++;
            }
            else
            {
                i += searchString.Length - 1;
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}