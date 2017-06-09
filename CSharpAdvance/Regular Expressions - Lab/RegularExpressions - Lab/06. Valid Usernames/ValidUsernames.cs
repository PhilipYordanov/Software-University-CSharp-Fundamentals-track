using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class ValidUsernames
    {
        static void Main()
        {
            var pattern = @"^[a-zA-Z0-9(_|\-)?]{3,16}$";

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
