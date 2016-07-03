using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse((Console.ReadLine()));
        List<Person> persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] personData = Console.ReadLine().Split(' ');
            persons.Add(new Person(personData[0], int.Parse(personData[1])));
        }

        List<Person> result = persons.Where(p => p.age > 30).OrderBy(p => p.name).ToList();

        foreach (var person in result)
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }
    }
}

class Person
{
    public string name;
    public int age;

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
    {
        this.name = "No name";
        this.age = age;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}