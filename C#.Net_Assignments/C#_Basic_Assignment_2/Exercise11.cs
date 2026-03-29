using System;

public class Exercise11
{
    public static void Run()
    {
        int n;

        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("Multiplication Table:");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}