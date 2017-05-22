using System;
using System.Collections.Generic;

public class Phonebook
{
    public static void Main()
    {
        string input;
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while ((input = Console.ReadLine()) != "search")
        {
            string[] tokens = input
                .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            string name = tokens[0];
            string number = tokens[1];

            phonebook[name] = number;
        }

        while ((input = Console.ReadLine()) != "stop")
        {
            string name = input;

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
    }
}