using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        var pattern = @"^[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+$";

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            if (Regex.Match(input, pattern).Success)
            {
                Console.WriteLine(input);
            }
        }
    }
}