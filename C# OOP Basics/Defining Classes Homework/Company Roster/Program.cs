using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] employeeData = Console.ReadLine().Split(' ');

            var employee = new Employee(employeeData[0], decimal.Parse(employeeData[1]), employeeData[2], employeeData[3]);

            if (employeeData.Length > 4)
            {
                var ageOrEmail = employeeData[4];
                if (ageOrEmail.Contains('@'))
                {
                    employee.email = ageOrEmail;
                }
                else
                {
                    employee.age = int.Parse(ageOrEmail);
                }
            }
            if (employeeData.Length > 5)
            {
                employee.age = int.Parse(employeeData[5]);
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.department)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.salary),
                Employees = e.OrderByDescending(emp => emp.salary)
            })
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");

        foreach (var employee in result.Employees)
        {
            Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
        }
    }
}

class Employee
{
    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.age = -1;
        this.email = "n/a";
    }
}