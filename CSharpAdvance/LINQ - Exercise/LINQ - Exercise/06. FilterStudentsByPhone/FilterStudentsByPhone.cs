using System;
using System.Collections.Generic;
using System.Linq;

public class FilterStudentsByPhone
{
    public static void Main()
    {
        string input;

        var stundets = new List<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            stundets.Add(input);
        }

        stundets
           .Select(s =>
           {
               var tokens = s.Split();
               var names = new List<string>();
               if (tokens[2].StartsWith("02") || tokens[2].StartsWith("+3592"))
               {
                   names.Add($"{tokens[0]} {tokens[1]}");
               }
               return new { names };
           })
           .Where(x => x.names.Count != 0)
           .ToList()
           .ForEach(x => Console.WriteLine(x.names[0]));
    }
}