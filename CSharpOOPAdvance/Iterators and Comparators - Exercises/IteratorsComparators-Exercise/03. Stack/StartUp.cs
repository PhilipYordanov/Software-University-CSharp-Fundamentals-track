using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static string[] parameters = null;
    private static string command;

    public static void Main()
    {
        var data = new Stack<int>();

        var commands = new Dictionary<string, Action>
        {
            {"Push", ()=> data.Push(parameters.Select(int.Parse).ToArray()) },
            {"Pop",() => data.Pop() }
        };

        while ((command = Console.ReadLine()) != "END")
        {
            var commandArgs = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var theCOmmand = commandArgs[0];
            commandArgs.RemoveAt(0);

            if (commands.ContainsKey(theCOmmand))
            {
                parameters = commandArgs.ToArray();
                try
                {
                    commands[theCOmmand].Invoke();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        PrintRest(data);
    }

    private static void PrintRest<T>(Stack<T> data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}