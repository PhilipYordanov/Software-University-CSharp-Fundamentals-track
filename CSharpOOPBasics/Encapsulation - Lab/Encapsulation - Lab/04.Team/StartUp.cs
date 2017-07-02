using System;

public class StartUp
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var team = new Team("Otbor");

        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0],
                                   cmdArgs[1],
                                   int.Parse(cmdArgs[2]),
                                   double.Parse(cmdArgs[3]));

                team.AddPlayer(person);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}