using System;
using System.Collections.Generic;
using System.Linq;
using _05.CompareObj;

public class StartUp
{
    public static void Main()
    {
        string input;

        var people = new List<Person>();

        while ((input = Console.ReadLine())!="END")
        {
            var tokens = input.Split();
            var currentPerson = new Person(tokens[0],int.Parse(tokens[1]),tokens[2]);
            people.Add(currentPerson);
        }

        var count = people.Count();
        var comparablePerson = int.Parse(Console.ReadLine());

        var choosenPerson = people[comparablePerson -1];
        people.RemoveAt(comparablePerson-1);
        var equalpeople = 1;
        var notEqualPeople = 0;
        foreach (var person in people)
        {
            if (choosenPerson.CompareTo(person) == 0)
            {
                equalpeople++;
            }
            else
            {
                notEqualPeople++;
            }
        }
        if (equalpeople == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalpeople} {notEqualPeople} {count}");
        }
    }
}