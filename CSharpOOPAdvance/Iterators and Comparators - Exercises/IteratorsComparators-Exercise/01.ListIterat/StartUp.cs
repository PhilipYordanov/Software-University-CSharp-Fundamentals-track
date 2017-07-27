using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static ListyIterator<string> _data;

    public static void Main()
    {
        string command;
        var createCommand = Console.ReadLine()
            .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

        _data = new ListyIterator<string>(createCommand.Skip(1).ToArray());

        var commands = new Dictionary<string, Action>
        {
            {"HasNext", () => Console.WriteLine(_data.HasNext())},
            {"Move", () => Console.WriteLine(_data.Move())},
            {"Print", () => _data.Print()}
        };

        while ((command = Console.ReadLine()) != "END")
        {
            var commandParams = command.Split();
            commands[commandParams[0]].Invoke();
        }
    }
}