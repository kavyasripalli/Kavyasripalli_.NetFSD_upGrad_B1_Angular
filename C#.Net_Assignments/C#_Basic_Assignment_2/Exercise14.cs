using System;

public class Exercise14
{
    public static void Run()
    {
        int num, smallest;

        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine(), out smallest))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        for (int i = 2; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (num < smallest)
            {
                smallest = num;
            }
        }

        Console.WriteLine("Smallest number is: " + smallest);
    }
}