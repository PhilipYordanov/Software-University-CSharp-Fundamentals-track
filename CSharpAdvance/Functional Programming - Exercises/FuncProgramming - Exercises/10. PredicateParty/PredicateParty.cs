using System;
using System.Linq;

public class PredicateParty
{
    public static void Main()
    {
        string input;

        var names = Console.ReadLine()
            .Split()
            .ToList();

        while ((input = Console.ReadLine()) != "Party!")
        {
            var tokens = input
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            var command = tokens[0];
            var predicate = tokens[1];
            var chechker = tokens[2];

            if (command == "Remove")
            {
                if (predicate == "StartsWith")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        names.RemoveAll(x => x.StartsWith(chechker));
                    }
                }
                else if (predicate == "EndsWith")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        names.RemoveAll(x => x.EndsWith(chechker));
                    }
                }
                else
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        names.RemoveAll(x => x.Length == int.Parse(chechker));
                    }
                }
            }
            else
            {
                if (predicate == "StartsWith")
                {
                    for (int i = names.Count - 1; i >= 0; i--)
                    {
                        if (names[i].StartsWith(chechker))
                        {
                            names.Add(names[i]);
                        }
                    }
                }
                else if (predicate == "EndsWith")
                {
                    for (int i = names.Count - 1; i >= 0; i--)
                    {
                        if (names[i].EndsWith(chechker))
                        {
                            names.Add(names[i]);
                        }
                    }
                }
                else
                {
                    for (int i = names.Count - 1; i >= 0; i--)
                    {
                        if (names[i].Length == int.Parse(chechker))
                        {
                            names.Add(names[i]);
                        }
                    }
                }
            }
        }

        if (names.Count != 0)
        {
            Console.WriteLine($"{string.Join(", ", names.OrderBy(x => x))} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
}