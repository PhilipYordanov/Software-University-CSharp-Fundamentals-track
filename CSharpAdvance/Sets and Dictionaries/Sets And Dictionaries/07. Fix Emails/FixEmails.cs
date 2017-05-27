using System;
using System.Collections.Generic;

public class FixEmails
{
    public static void Main()
    {
        string inputLine;
        int count = 1;
        string name = string.Empty;

        Dictionary<string, string> name_email = new Dictionary<string, string>();

        while ((inputLine = Console.ReadLine()) != "stop")
        {
            count++;
            if (count % 2 == 0)
            {
                name = inputLine;
                if (!name_email.ContainsKey(inputLine))
                {
                    name_email[inputLine] = "";
                }
            }
            else
            {
                if (!inputLine.EndsWith("eu"))
                {
                    if (!inputLine.EndsWith("us"))
                    {
                        name_email[name] = inputLine;
                    }
                }
            }
        }

        foreach (var kvp in name_email)
        {
            if (kvp.Value != "")
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}