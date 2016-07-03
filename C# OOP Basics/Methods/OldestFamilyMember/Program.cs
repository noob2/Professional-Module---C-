using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        Family family = new Family(new List<Person>());

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var name = input[0];
            var age = int.Parse(input[1]);

            var person = new Person(name, age);

            family.AddMember(person);
        }

        var oldestInTheFamily = family.GetOldestMember();

        Console.WriteLine($"{oldestInTheFamily.Name} {oldestInTheFamily.Age}");
    }
}

public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public int Age { get; set; }

    public string Name { get; set; }
}

public class Family
{
    public Family(List<Person> familyMembers)
    {
        this.FamilyMembers = familyMembers;
    }

    public List<Person> FamilyMembers { get; set; }

    public void AddMember(Person member)
    {
        this.FamilyMembers.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.FamilyMembers.OrderByDescending(p => p.Age).First();
    }
}