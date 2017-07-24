using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input;
        var nation =new List<IIdentifiable>();

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input
                .Split();

            if (tokens.Length > 2)
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var id = tokens[2];

                Citizen citizen = new Citizen(name, age, id);
                nation.Add(citizen);
            }
            else
            {
                var model = tokens[0];
                var id = tokens[1];

                Robot robot = new Robot(model, id);
                nation.Add(robot);
            }
        }

        var check = Console.ReadLine();

        Console.WriteLine(string.Join(Environment.NewLine,nation
            .Where(e => e.Id.EndsWith(check))
            .Select(x=>x.Id)));
    }
}