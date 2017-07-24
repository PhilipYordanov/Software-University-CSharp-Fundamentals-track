using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int numberOfpeople = int.Parse(Console.ReadLine());
        
        var people = new Dictionary<string, IBuyer>();

        for (int i = 0; i < numberOfpeople; i++)
        {
            var tokens = Console.ReadLine().Split();

            if (tokens.Length > 3)
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var id = tokens[2];
                var birthdate = tokens[3];

                Citizen citizen = new Citizen(name, age, id, birthdate);
                people[name] = citizen;
            }
            else
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var group = tokens[2];

                Rebel rebel = new Rebel(name, age, group);
                people[name] = rebel;
            }
        }

        string buyer;
        while ((buyer = Console.ReadLine()) != "End")
        {
            if (people.ContainsKey(buyer))
            {
                people[buyer].BuyFood();
            }
        }
        Console.WriteLine(people.Values.Sum(b => b.Food));
    }
}