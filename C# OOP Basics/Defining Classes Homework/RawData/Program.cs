using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());



        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);

            Tier[] tiers = new Tier[4];
            tiers[0] = new Tier(double.Parse(input[5]), int.Parse(input[6]));
            tiers[1] = new Tier(double.Parse(input[7]), int.Parse(input[8]));
            tiers[2] = new Tier(double.Parse(input[9]), int.Parse(input[10]));
            tiers[3] = new Tier(double.Parse(input[11]), int.Parse(input[12]));

            Car car = new Car(input[0], engine, cargo, tiers);

            cars.Add(car);
        }

        string type = Console.ReadLine();

        if (type == "fragile")
        {
            var fragileCars = cars.FindAll(c => c.cargo.type == "fragile" && c.tiers.Any(t => t.pressure < 1));
            foreach (var car in fragileCars)
            {
                Console.WriteLine(car.model);
            }
        }

        if (type == "flamable")
        {
            var fragileCars = cars.FindAll(c => c.cargo.type == "flamable" && c.engine.power > 250);
            foreach (var car in fragileCars)
            {
                Console.WriteLine(car.model);
            }
        }
    }
}

class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public Tier[] tiers;

    public Car(string model, Engine engine, Cargo cargo, Tier[] tiers)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tiers = tiers;
    }
}

class Engine
{
    public int speed;
    public int power;

    public Engine(int speed, int power)
    {
        this.speed = speed;
        this.power = power;
    }
}

class Cargo
{
    public int weight;
    public string type;

    public Cargo(int weight, string type)
    {
        this.weight = weight;
        this.type = type;
    }
}

class Tier
{
    public double pressure;
    public int age;

    public Tier(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }
}