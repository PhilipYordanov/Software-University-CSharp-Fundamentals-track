using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static ListyIterator<string> data;

    public static void Main()
    {
        string command;
        var createCommand = Console.ReadLine()
            .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

        data = new ListyIterator<string>(createCommand
            .Skip(1)
            .ToArray());

        var commands = new Dictionary<string, Action>
        {
            {"HasNext", () => Console.WriteLine(data.HasNext())},
            {"Move", () => Console.WriteLine(data.Move())},
            {"Print", () => Console.WriteLine(data.Print())},
            {"PrintAll", () => Console.WriteLine(data.PrintAll()) }
        };

        while ((command = Console.ReadLine()) != "END")
        {
            var commandName = command.Split().ToArray().FirstOrDefault();
			if(commands.ContainsKey(command)){
            try
            {
                commands[commandName].Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }}
        }
    }
}