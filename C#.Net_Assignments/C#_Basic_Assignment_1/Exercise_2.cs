using System;

public class Exercise_2
{
    public static void Run()
    {
        double km, meters;

        Console.Write("Enter distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());

        meters = km * 1000;

        Console.WriteLine("Distance in meters = " + meters);
    }
}