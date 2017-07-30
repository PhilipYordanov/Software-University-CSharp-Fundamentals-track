using _09.Traffic_Lights.Enums;
using System;
using System.Linq;

namespace _09.Traffic_Lights
{
    public class StartUp
    {
        public static void Main()
        {
            var lightsArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray()
                .Select(x => (Lights)Enum.Parse(typeof(Lights), x))
                .ToArray();

            var numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int currentLight = 0;
                foreach (var light in lightsArray)
                {
                    lightsArray[currentLight] = EnumGetter.GetNextValueOf(lightsArray[currentLight]);
                    currentLight++;
                }
                Console.WriteLine(string.Join(" ",lightsArray));
            }
        }

        public class EnumGetter
        {
            public static Lights GetNextValueOf(Lights value)
            {
                return (from Lights light in Enum.GetValues(typeof(Lights))
                        where light > value
                        orderby light
                        select light).DefaultIfEmpty().First();
            }
        }
    }
}
