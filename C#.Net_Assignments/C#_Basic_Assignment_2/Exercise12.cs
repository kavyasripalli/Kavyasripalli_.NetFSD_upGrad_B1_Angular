using System;

public class Exercise12
{
    public static void Run()
    {
        Console.WriteLine("Numbers divisible by 7 between 200 and 300:");

        for (int i = 200; i <= 300; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}