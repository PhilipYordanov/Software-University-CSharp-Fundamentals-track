using System;
using System.Linq;

public class CharacterMultiplier
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var firstWord = input[0];
        var secondWord = input[1];

        var sum = CharMultiplier(firstWord, secondWord);
        Console.WriteLine(sum);
    }

    public static int CharMultiplier(string firstWord, string secondWord)
    {
        var strings = new string[] { firstWord, secondWord };

        string shorter = strings.OrderBy(s => s.Length).First();
        string longer = strings.OrderByDescending(s => s.Length).First();

        var sum = 0;

        for (int i = 0; i < shorter.Length; i++)
        {
            sum += firstWord[i] * secondWord[i];
        }

        for (int i = 0; i < longer.Length - shorter.Length; i++)
        {
            sum += longer[longer.Length - 1 - i];
        }

        return sum;
    }
}