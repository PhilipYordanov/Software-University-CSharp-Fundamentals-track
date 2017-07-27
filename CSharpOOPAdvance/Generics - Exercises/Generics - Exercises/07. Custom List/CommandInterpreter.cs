using System;
using System.Collections.Generic;

public class CommandInterpreter
{
    private readonly CustomList<string> _list = new CustomList<string>();

    public void ParseCommand(string commandParams)
    {
        var commandTokens = commandParams.Split(' ');
        var command = commandTokens[0];

        var commandDictionary = new Dictionary<string, Action>
        {
            {"Add",() => this._list.Add(commandTokens[1]) },
            {"Remove",() => this._list.Remove(int.Parse(commandTokens[1])) },
            {"Contains",() => Console.WriteLine(this._list.Contains(commandTokens[1])) },
            {"Swap",() =>   this._list.Swap(int.Parse(commandTokens[1]), int.Parse(commandTokens[2]))},
            {"Greater",() => Console.WriteLine(this._list.CountGreaterThan(commandTokens[1])) },
            {"Max",() =>  Console.WriteLine(this._list.Max())},
            {"Min",() =>  Console.WriteLine(this._list.Min())},
            {"Print",() => this._list.ForEach()}
        };

        if (commandDictionary.ContainsKey(command))
        {
            commandDictionary[command].Invoke();
        }
    }
}