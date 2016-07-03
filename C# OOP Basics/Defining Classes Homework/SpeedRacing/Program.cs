using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            double fuel = double.Parse(input[1]);
            double fuelConsumption = double.Parse(input[2]);

            Car car = new Car(model, fuel, fuelConsumption);
            cars.Add(car);
        }

        string driveCommand = Console.ReadLine();
        while (driveCommand != "End")
        {
            string[] driveCommandArgs = driveCommand.Split();
            string carModel = driveCommandArgs[1];
            double amountOfKilometers = double.Parse(driveCommandArgs[2]);
            Car carToDrive = cars.First(c => c.model == carModel);
            carToDrive.Drive(amountOfKilometers);
            driveCommand = Console.ReadLine();
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.model} {car.fuel:F2} {car.distanceTravelled}");
        }
    }
}

class Car
{
    public string model;
    public double fuel;
    public double fuelCostPerKilometer;
    public double distanceTravelled;

    public Car(string model, double fuel, double fuelCostPerKilometer)
    {
        this.model = model;
        this.fuel = fuel;
        this.fuelCostPerKilometer = fuelCostPerKilometer;
        this.distanceTravelled = 0;
    }

    public void Drive(double amountOfKilometers)
    {
        if (amountOfKilometers <= this.fuel / this.fuelCostPerKilometer)
        {
            this.distanceTravelled += amountOfKilometers;
            this.fuel -= this.fuelCostPerKilometer * this.distanceTravelled;
        }
    }
}
