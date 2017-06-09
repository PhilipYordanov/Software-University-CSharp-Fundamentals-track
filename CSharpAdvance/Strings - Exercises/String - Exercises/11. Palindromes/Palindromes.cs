using System;
using System.Collections.Generic;
using System.Linq;

public class Palindromes
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ', ',', '!', '-', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

        var palindromes = new HashSet<string>();

        var isPalindrome = false;
        foreach (var word in input)
        {
            if (word.Length == 1)
            {
                palindromes.Add(word);
            }
            else
            {
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] == word[word.Length - i - 1])
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome == true)
                {
                    palindromes.Add(word);
                }
            }
        }
        var orderedPalindromes = palindromes.ToList();
        orderedPalindromes.Sort((a, b) => a.CompareTo(b));
        Console.WriteLine($"[{string.Join(", ", orderedPalindromes)}]");
    }
}