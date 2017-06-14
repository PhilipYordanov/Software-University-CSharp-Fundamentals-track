namespace _07.Valid_Time
{
    using System;
    using System.Text.RegularExpressions;

    class ValidTime
    {
        static void Main(string[] args)
        {
            var pattern = @"[0-12]{2}:[0-59]{2}:[0-59]{2}\s(A|P)M";

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var matches = Regex.Match(input, pattern);

                if (matches.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
