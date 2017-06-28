using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string name;

    public int? age;

    public Person(string name , int age)
    {
        if (age > 30)
        {
            this.name = name;
            this.age = age;
        }
        else
        {
            this.name = null;
            this.age = null;
        }
    }
}

public class OpinionPoll
{
    public static void Main()
    {
        var numberOfPeoplle = int.Parse(Console.ReadLine());

        var people = new List<Person>();

        for (int i = 0; i < numberOfPeoplle; i++)
        {
            var personTokens = Console.ReadLine()
                .Split();
            var name = personTokens[0];
            var age = int.Parse(personTokens[1]);

            var currentPerson = new Person(name, age);

            people.Add(currentPerson);
        }

        people
            .Where(x => x.name != null)
            .OrderBy(x => x.name)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.name} - {x.age}"));
    }
}