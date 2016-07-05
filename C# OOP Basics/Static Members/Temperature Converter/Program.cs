using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();


        while (input != "End")
        {
            Temperature.temperature = input;
            Temperature.Convert();
            Console.WriteLine(Temperature.temperature);

            input = Console.ReadLine();
        }
    }
}

public static class Temperature
{
    public static string temperature;

    public static void Convert()
    {
        var inputParams = temperature.Split();

        var temperatureValue = double.Parse(inputParams[0]);
        var temperatureType = inputParams[1];

        double outputTemperature = 0;
        string outputType;
        if (temperatureType == "Celsius")
        {
            outputTemperature = temperatureValue * 9 / 5 + 32;
            outputType = "Fahrenheit";
        }
        else
        {
            outputTemperature = (temperatureValue - 32) * 5 / 9;
            outputType = "Celsius";
        }

        temperature = string.Format($"{outputTemperature:F2} {outputType}");
    }
}
