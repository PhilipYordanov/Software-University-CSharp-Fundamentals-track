using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Intersection
{
    public class Program
    {
        public static void Main()
        {
            var inputParms = Console.ReadLine()
                .Split();

            var numberOfRectangles = int.Parse(inputParms[0]);
            var numberOfIntersections = int.Parse(inputParms[1]);

            var listOfRectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();

                var currentRect = new Rectangle(tokens[0]
                    , double.Parse(tokens[1])
                    , double.Parse(tokens[2])
                    , double.Parse(tokens[3])
                    , double.Parse(tokens[4]));

                listOfRectangles.Add(currentRect);
            }

            for (int i = 0; i < numberOfIntersections; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();

                var first = listOfRectangles
                    .Where(x => x.Id == tokens[0])
                    .FirstOrDefault();

                var second = listOfRectangles
                    .Where(x => x.Id == tokens[1])
                    .FirstOrDefault();

                if (first.IntersectRectangles(second))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
