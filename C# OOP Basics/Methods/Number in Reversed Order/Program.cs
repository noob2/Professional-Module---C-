using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        DecimalNumber number = new DecimalNumber(n);

        Console.WriteLine(number.Reverse());
    }
}

class DecimalNumber
{
    public DecimalNumber(double number)
    {
        Number = number;
    }

    public double Number { get; set; }

    public string Reverse()
    {
        return new string(this.Number.ToString().Reverse().ToArray());
    }
}
