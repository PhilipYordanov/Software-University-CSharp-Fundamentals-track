using System;
using System.Linq;

public class ParseURLs
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var protocolSeparator = "://";
       
        var firstIndex = inputLine.IndexOf(protocolSeparator);
        if (firstIndex != -1)
        {
            var result = firstIndex != inputLine.LastIndexOf(protocolSeparator) && firstIndex != -1;
            if (!result)
            {
                var tokens = inputLine
                    .Split(new string[] { protocolSeparator }, StringSplitOptions.None)
                    .ToArray();

                var protocol = tokens[0];

                int serverEndIndex = tokens[1].IndexOf("/");
                if (serverEndIndex != -1)
                {
                    string server = tokens[1].Substring(0, serverEndIndex);
                    string resource = tokens[1].Substring(serverEndIndex + 1);
                    Console.WriteLine($"Protocol = {protocol}");
                    Console.WriteLine($"Server = {server}");
                    Console.WriteLine($"Resources = {resource}");
                }
                else
                {
                    Console.WriteLine("Invalid URL");
                }
            }
            else
            {
                Console.WriteLine("Invalid URL");
            }
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }
}