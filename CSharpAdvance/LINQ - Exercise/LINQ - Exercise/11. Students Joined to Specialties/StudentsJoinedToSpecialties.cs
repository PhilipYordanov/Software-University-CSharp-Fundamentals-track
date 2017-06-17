using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsJoinedToSpecialties
{
    public static void Main()
    {
        string input;
        var studentSpecialties = new List<StudentSpecialty>();
        var students = new List<Student>();

        while ((input = Console.ReadLine()) != "Students:")
        {
            var tokens = input
                .Split();
            var currentSpec = new StudentSpecialty()
            {
                SpecialtyName = $"{tokens[0]} {tokens[1]}",
                FacultyNumber = int.Parse(tokens[2])
            };
            studentSpecialties.Add(currentSpec);
        }

        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input
                .Split();
            var currentStudent = new Student()
            {
                StudentName = $"{tokens[1]} {tokens[2]}",
                FacultyNumber = int.Parse(tokens[0])
            };
            students.Add(currentStudent);
        }

        students.Join(
            studentSpecialties,
         a => a.FacultyNumber,
         m => m.FacultyNumber,
         (a, m) => new { a.StudentName, a.FacultyNumber, m.SpecialtyName })
         .OrderBy(x => x.StudentName)
         .ToList()
         .ForEach(x => Console.WriteLine($"{x.StudentName} {x.FacultyNumber} {x.SpecialtyName}"));
    }
}
