using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            Student.studentNames.Add(new Student(input));

            input = Console.ReadLine();
        }


        Console.WriteLine(Student.studentNames.Count);
    }
}

public class Student
{
    public static HashSet<Student> studentNames;

    public string name { get; set; }

    static Student()
    {
        studentNames = new HashSet<Student>();
    }

    public Student(string name)
    {
        this.name = name;
    }

    public override bool Equals(object other)
    {
        return this.GetHashCode().Equals(other.GetHashCode());
    }

    public override int GetHashCode()
    {
        return this.name.GetHashCode();
    }
}