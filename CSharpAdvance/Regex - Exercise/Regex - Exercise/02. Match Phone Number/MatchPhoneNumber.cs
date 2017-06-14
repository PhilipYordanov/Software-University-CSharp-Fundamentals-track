using System;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        var pattern = @"\+[359]+( |-)\d\1\d{3}\1\d{4}$";

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