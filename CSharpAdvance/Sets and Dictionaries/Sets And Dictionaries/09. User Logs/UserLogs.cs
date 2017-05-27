using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        string input;

        var name_message = new Dictionary<string, Dictionary<string, int>>();

        while ((input = Console.ReadLine()) != "end")
        {
            var tokens = input
                .Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var ip = tokens[1];
            var message = tokens[3];
            var user = tokens[5];

            if (!name_message.ContainsKey(user))
            {
                name_message[user] = new Dictionary<string, int>();
                name_message[user][ip] = 1;
            }
            else
            {
                if (!name_message[user].ContainsKey(ip))
                {
                    name_message[user][ip] = 1;
                }
                else
                {
                    name_message[user][ip]++;
                }
            }
        }

        int counter = 0;

        foreach (var kvp in name_message.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: ");
            foreach (var kvp2 in kvp.Value)
            {
                counter++;
                if (counter == kvp.Value.Count)
                {
                    Console.Write($"{kvp2.Key} => {kvp2.Value}.");
                    counter = 0;
                }
                else
                {
                    Console.Write($"{kvp2.Key} => {kvp2.Value}, ");
                }
            }

            Console.WriteLine();
        }
    }
}