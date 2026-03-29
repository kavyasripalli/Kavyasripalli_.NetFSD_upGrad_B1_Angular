using System;

public class Exercise9
{
    public static void Run()
    {
        int n;
        long fact = 1;

        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}