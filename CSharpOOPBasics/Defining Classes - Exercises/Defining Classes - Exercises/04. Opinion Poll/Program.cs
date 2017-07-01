using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listOfPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                Person currentperson = null;
                try
                {
                    currentperson = new Person(line[0], int.Parse(line[1]));
                    listOfPeople.Add(currentperson);
                }
                catch (Exception)
                {
                }
            }

            foreach (var p in listOfPeople.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}
