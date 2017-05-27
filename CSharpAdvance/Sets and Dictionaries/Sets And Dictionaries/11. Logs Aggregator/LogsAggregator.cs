namespace _11.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var numberOfLogs = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> userIpDuration = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLogs; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var userName = tokens[1];
                var ipAdress = tokens[0];
                var logDuration = int.Parse(tokens[2]);

                DataMining(userIpDuration, userName, ipAdress, logDuration);
            }

            PrintOutputPrintUserIpDurationCollection(userIpDuration);
        }

        private static void DataMining(Dictionary<string, Dictionary<string, int>> userIpDuration, string userName, string ipAdress, int logDuration)
        {
            if (userIpDuration.ContainsKey(userName))
            {
                if (userIpDuration[userName].ContainsKey(ipAdress))
                {
                    userIpDuration[userName][ipAdress] += logDuration;
                }
                else
                {
                    userIpDuration[userName].Add(ipAdress, logDuration);
                }
            }
            else
            {
                userIpDuration[userName] = new Dictionary<string, int>();
                userIpDuration[userName].Add(ipAdress, logDuration);
            }
        }

        private static void PrintOutputPrintUserIpDurationCollection(Dictionary<string, Dictionary<string, int>> userIpDuration)
        {
            foreach (var kvp in userIpDuration.OrderBy(n => n.Key))
            {
                var currentUserName = kvp.Key;
                var currentTotalDuration = kvp.Value.Values.Sum();
                var currentUserOrderedIps = kvp.Value.Keys.OrderBy(i => i);
                Console.WriteLine($"{currentUserName}: {currentTotalDuration} [{string.Join(", ", currentUserOrderedIps)}]");
            }
        }
    }
}
