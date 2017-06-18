namespace BashSoft
{
    using System;

    public static class InputReader
    {
        private const string EndCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
            string input;
            while ((input = Console.ReadLine()) != EndCommand)
            {
                CommandInterpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}> ");
                input = input.Trim();
            }
        }
    }
}
