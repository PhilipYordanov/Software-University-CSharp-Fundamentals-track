using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidUsernames
{
    public static void Main()
    {
        var inputLine = Console.ReadLine()
            .Split(new[] { '/', '\\', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length >= 3)
            .Where(x => x.Length <= 25)
            .ToArray();

        var pattern = @"(^[a-zA-Z]+\w*)";

        var filtredInput = new List<string>();
        foreach (var word in inputLine)
        {
            if (Regex.IsMatch(word, pattern))
            {
                filtredInput.Add(word);
            }
        }

        string firstWord = null;
        string secondWord = null;
        string firstWordMaxLen = null;
        string secondWordMaxLen = null;

        var sum = 0;

        for (int i = 0; i < filtredInput.Count - 1; i++)
        {
            firstWord = filtredInput[i];
            secondWord = filtredInput[i + 1];

            var currentSum = firstWord.Length + secondWord.Length;

            if (sum < currentSum)
            {
                sum = currentSum;
                firstWordMaxLen = filtredInput[i];
                secondWordMaxLen = filtredInput[i + 1];
            }
        }

        Console.WriteLine(firstWordMaxLen);
        Console.WriteLine(secondWordMaxLen);
    }
}