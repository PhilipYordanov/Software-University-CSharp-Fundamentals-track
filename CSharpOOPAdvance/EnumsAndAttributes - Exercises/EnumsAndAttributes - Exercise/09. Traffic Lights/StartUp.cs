using _09.Traffic_Lights.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Traffic_Lights
{
    public class StartUp
    {
        public static void Main()
        {
            var lightsArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (Light)Enum.Parse(typeof(Light), x))
                .ToArray();

            var numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int currentLight = 0;
                foreach (var light in lightsArray)
                {
                    lightsArray[currentLight] = GetNextValueOf(lightsArray[currentLight]);
                    currentLight++;
                }
                Console.WriteLine(string.Join(" ", lightsArray));
            }
        }
        public static Light GetNextValueOf(Light value)
        {
            return (from Light light in Enum.GetValues(typeof(Light))
                    where light > value
                    orderby light
                    select light).DefaultIfEmpty().First();
        }
    }
}
