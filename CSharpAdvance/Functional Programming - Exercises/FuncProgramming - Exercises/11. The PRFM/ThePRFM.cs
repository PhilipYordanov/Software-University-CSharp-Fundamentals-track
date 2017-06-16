using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ThePRFM
{
    public static void Main()
    {
        List<string> guests = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;
        List<string> beforeFiltering = new List<string>(guests);

        while ((input = Console.ReadLine()) != "Print")
        {
            var tokens = input
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];
            string filterType = tokens[1];
            string parameter = tokens[2];

            ApplyFiltering(guests, beforeFiltering, command, filterType, parameter);
        }

        StringBuilder sb = new StringBuilder();

        foreach (string guest in guests)
        {
            if (!guest.Equals(string.Empty))
            {
                sb.Append(guest + " ");
            }
        }

        Console.WriteLine(sb);
    }

    private static void ApplyFiltering(List<string> guestsList, List<string> beforeFiltering, string command, string filterType, string parameter)
    {
        Predicate<string> startsWith = s => s.StartsWith(parameter);
        Predicate<string> endsWith = s => s.EndsWith(parameter);
        Predicate<string> length = s => s.Length == int.Parse(parameter);
        Predicate<string> contains = s => s.Contains(parameter);

        if (command.Equals("Add filter"))
        {
            List<string> removed = new List<string>();

            switch (filterType)
            {
                case "Starts with":
                    removed = guestsList.FindAll(startsWith);
                    break;
                case "Ends with":
                    removed = guestsList.FindAll(endsWith);
                    break;
                case "Length":
                    removed = guestsList.FindAll(length);
                    break;
                case "Contains":
                    removed = guestsList.FindAll(contains);
                    break;
            }

            foreach (string removeName in removed)
            {
                for (int i = 0; i < guestsList.Count; i++)
                {
                    if (guestsList[i].Equals(removeName))
                    {
                        guestsList[i] = string.Empty;
                    }
                }
            }
        }
        else if (command.Equals("Remove filter"))
        {
            List<string> addBack = new List<string>();

            switch (filterType)
            {
                case "Starts with":
                    addBack = beforeFiltering.FindAll(startsWith);
                    break;
                case "Ends with":
                    addBack = beforeFiltering.FindAll(endsWith);
                    break;
                case "Length":
                    addBack = beforeFiltering.FindAll(length);
                    break;
                case "Contains":
                    addBack = beforeFiltering.FindAll(contains);
                    break;
            }

            foreach (var person in addBack)
            {
                var index = beforeFiltering.LastIndexOf(person);
                guestsList[index] = person;
            }
        }
    }
}