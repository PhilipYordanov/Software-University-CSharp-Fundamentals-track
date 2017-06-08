using System;
using System.Collections.Generic;

public class SpecialWords
{
    public static void Main()
    {
        var specialWords = Console.ReadLine().Split() ;
        var result =new Dictionary<string, int>();

        for (int i = 0; i < specialWords.Length; i++)
        {
            result.Add(specialWords[i],0);
        }
        var separator = new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?',' ' };

        var inputText = Console.ReadLine();
        var plainText = inputText.Split(separator,StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in plainText)
        {
            if (result.ContainsKey(word))
            {
                result[word] += 1;
            }
        }

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}