using System;

public class StartUp
{
    public static void Main()
    {
        var interpretator = new CommandInterpreter();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            interpretator.ParseCommand(input);
        }
    }
}