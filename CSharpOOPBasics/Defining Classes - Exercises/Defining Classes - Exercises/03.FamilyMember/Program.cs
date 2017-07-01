using System;
using System.Reflection;

namespace _03.FamilyMember
{
    public class Program
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }
            var members = new Family();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                var currentperson = new Person()
                {
                    Name = line[0],
                    Age = int.Parse(line[1])
                };
            
                members.AddMember(currentperson);
            }
            PrintOldestMember(members);
        }

        private static void PrintOldestMember(Family members)
        {
            Console.WriteLine($"{members.GetOldestMember().Name} {members.GetOldestMember().Age}");
        }
    }
}
