using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var animalParams = input.Split();
            var name = animalParams[0];
            var breed = animalParams[1];
            var clinicAction = animalParams[2];
            var animal = new Animal(name, breed);

            AnimalClinic.Cure(animal, clinicAction);

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
        Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");

        if (input == "rehabilitate")
        {
            AnimalClinic.PrintRehabilitated();
        }
        else
        {
            AnimalClinic.PrintHealed();
        }
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Animal(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }
}

public static class AnimalClinic
{
    private static List<Animal> healed = new List<Animal>();
    private static List<Animal> rehabilitated = new List<Animal>();

    public static int patientId = 1;
    public static int healedAnimalsCount;
    public static int rehabilitedAnimalsCount;

    public static void Cure(Animal animal, string procedureType)
    {
        if (procedureType == "heal")
        {
            healed.Add(animal);
            healedAnimalsCount++;

            Console.WriteLine($"Patient {patientId}: [{animal.Name} ({animal.Breed})] has been healed!");
        }
        else
        {
            rehabilitated.Add(animal);
            rehabilitedAnimalsCount++;

            Console.WriteLine($"Patient {patientId}: [{animal.Name} ({animal.Breed})] has been rehabilitated!");
        }
        patientId++;
    }

    public static void PrintRehabilitated()
    {
        foreach (var animal in rehabilitated)
        {
            Console.WriteLine($"{animal.Name} {animal.Breed}");
        }
    }

    public static void PrintHealed()
    {
        foreach (var animal in healed)
        {
            Console.WriteLine($"{animal.Name} {animal.Breed}");
        }
    }


}