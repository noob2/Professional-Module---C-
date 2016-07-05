using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        List<Student> students = new List<Student>();

        while (input != "End")
        {
            students.Add(new Student(input));

            input = Console.ReadLine();
        }


        Console.WriteLine(Student.totalStudents);
    }
}

public class Student
{
    public static int totalStudents = 0;

    public string name { get; set; }

    public Student(string name)
    {
        totalStudents++;
        this.name = name;
    }
}