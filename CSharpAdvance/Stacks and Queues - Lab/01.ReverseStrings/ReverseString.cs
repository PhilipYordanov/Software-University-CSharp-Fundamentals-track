using System;
using System.Collections.Generic;
using System.Text;

public class ReverseString
{
    public static void Main()
    {
        var inputLine = Console.ReadLine().ToCharArray();

        Stack<char> chars = new Stack<char>();

        foreach (var symbol in inputLine)
        {
            chars.Push(symbol);
        }

        StringBuilder result = new StringBuilder();
        foreach (var symbol in chars)
        {
            result.Append(symbol).Append(string.Empty);
        }

        Console.WriteLine(result);
    }
}