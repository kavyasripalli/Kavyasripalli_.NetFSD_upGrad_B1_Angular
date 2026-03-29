using System;

public class Exercise_5
{
    public static void Run()
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Highest number is: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("Highest number is: " + num2);
        }
        else
        {
            Console.WriteLine("Both numbers are equal");
        }
    }
}