using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = Console.ReadLine();
            List<string> commandParamateres = inputCommand
                .Split()
                .ToList();

            string command = commandParamateres[0];

            commandParamateres.Remove(command);

            switch (command)
            {
                case "Bender":
                    this.nationsBuilder.AssignBender(commandParamateres);
                    break;
                case "Monument":
                    this.nationsBuilder.AssignMonument(commandParamateres);
                    break;
                case "Status":
                    string status = this.nationsBuilder.GetStatus(commandParamateres[0]);
                    Console.WriteLine(status);
                    break;
                case "War":
                    this.nationsBuilder.IssueWar(commandParamateres[0]);
                    break;
                case "Quit":
                    string record = this.nationsBuilder.GetWarsRecord();
                    Console.WriteLine(record);
                    this.isRunning = false;
                    break;
            }
        }
    }
}