using System;
using System.Text;

public class ConcatenateStrings
{
    public static void Main()
    {
        var numberOfWords = int.Parse(Console.ReadLine());

        var sb = new StringBuilder();
        for (int i = 0; i < numberOfWords; i++)
        {
            var currentWord = Console.ReadLine();
            sb.Append(currentWord).Append(" ");
        }
        Console.WriteLine(sb);
    }
}