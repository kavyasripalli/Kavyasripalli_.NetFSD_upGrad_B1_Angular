using System;

public class Exercise_1
{
    public static void Run()
    {
        int num1, num2;
        double quotient;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        else
        {
            quotient = (double)num1 / num2;
            Console.WriteLine("Quotient = " + quotient);
        }
    }
}
