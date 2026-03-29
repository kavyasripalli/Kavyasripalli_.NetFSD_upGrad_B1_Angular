using System;

public class Exercise6
{
    public static void Run()
    {
        double fahrenheit, celsius;

        Console.Write("Enter temperature in Fahrenheit: ");

        if (!double.TryParse(Console.ReadLine(), out fahrenheit))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        celsius = (5.0 / 9) * (fahrenheit - 32);

        Console.WriteLine("Temperature in Celsius = " + celsius);
    }
}