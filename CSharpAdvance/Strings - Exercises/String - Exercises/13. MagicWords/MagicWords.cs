using System;
using System.Collections.Generic;

public class MagicWords
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split();

        HashSet<char> firstWord = new HashSet<char>(input[0]);
        HashSet<char> secondWord = new HashSet<char>(input[1]);

        Console.WriteLine(firstWord.Count == secondWord.Count ? "true" : "false");
    }
}