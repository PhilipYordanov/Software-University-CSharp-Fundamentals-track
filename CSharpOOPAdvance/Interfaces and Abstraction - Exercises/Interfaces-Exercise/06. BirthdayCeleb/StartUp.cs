using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string input;
        var nation = new List<IBirthable>();

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input
                .Split();

            if (tokens[0] == "Citizen")
            {
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var id = tokens[3];
                var birthday = tokens[4];

                Citizen citizen = new Citizen(name, age, id,birthday);
                nation.Add(citizen);
            }
            else if(tokens[0] == "Robot")
            {
                var model = tokens[0];
                var id = tokens[1];

                Robot robot = new Robot(model, id);
            }
            else
            {
                //<name> <birthdate>
                var name = tokens[1];
                var birthday = tokens[2];

                Pet pet = new Pet(name,birthday);
                nation.Add(pet);
            }
        }

        var check = Console.ReadLine();

        Console.WriteLine(string.Join(Environment.NewLine, nation
            .Where(e => e.BirthDay.EndsWith(check))
            .Select(x => x.BirthDay)));
    }
}