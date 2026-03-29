using System;

public class Exercise4
{
    public static void Run()
    {
        int num;

        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (num % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
    }
}