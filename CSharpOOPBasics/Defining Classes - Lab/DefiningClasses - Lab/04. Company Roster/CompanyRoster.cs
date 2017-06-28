using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    public static void Main()
    {
        var numberOfEmployees = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();

        for (int i = 0; i < numberOfEmployees; i++)
        {
            var employeeInfo = Console.ReadLine()
                .Split();
            var employeeName = employeeInfo[0];
            var employeeSalary = decimal.Parse(employeeInfo[1]);
            var employeePosition = employeeInfo[2];
            var employeeDepartment = employeeInfo[3];

            var emplyee = new Employee(
                employeeName,
                employeeSalary,
                employeePosition,
                employeeDepartment);

            if (employeeInfo.Length > 5)
            {
                emplyee.age = int.Parse(employeeInfo[5]);
            }

            if (employeeInfo.Length > 4)
            {
                var ageOrEmail = employeeInfo[4];
                if (ageOrEmail.Contains("@"))
                {
                    emplyee.email = ageOrEmail;
                }
                else
                {
                    emplyee.age = int.Parse(ageOrEmail);
                }
            }

            employees.Add(emplyee);
        }

        var bestDepartment = employees
             .GroupBy(e => e.department)
             .Select(e => new
             {
                 Depatment = e.Key,
                 AverageSalary = e.Average(emp => emp.salary),
                 Employees = e.OrderByDescending(emp => emp.salary)
             })
             .OrderByDescending(dep => dep.AverageSalary)
             .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {bestDepartment.Depatment}");

        foreach (var employee in bestDepartment.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.salary:F2} {employee.email} {employee.age}");
        }
    }
}