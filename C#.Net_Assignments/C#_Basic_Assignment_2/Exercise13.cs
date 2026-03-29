using System;

public class Exercise13
{
    public static void Run()
    {
        int a, b, c;

        Console.Write("Enter first number: ");
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.Write("Enter second number: ");
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.Write("Enter third number: ");
        if (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (a > b && a > c)
        {
            Console.WriteLine("Largest number is: " + a);
        }
        else if (b > c)
        {
            Console.WriteLine("Largest number is: " + b);
        }
        else
        {
            Console.WriteLine("Largest number is: " + c);
        }
    }
}