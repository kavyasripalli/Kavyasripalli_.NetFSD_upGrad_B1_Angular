using System;

public class Exercise7
{
    public static void Run()
    {
        double distance, speed, time;

        Console.Write("Enter distance: ");
        distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter speed: ");
        speed = Convert.ToDouble(Console.ReadLine());

        if (speed == 0)
        {
            Console.WriteLine("Speed cannot be zero");
        }
        else
        {
            time = distance / speed;
            Console.WriteLine("Time taken = " + time + " hours");
        }
    }
}