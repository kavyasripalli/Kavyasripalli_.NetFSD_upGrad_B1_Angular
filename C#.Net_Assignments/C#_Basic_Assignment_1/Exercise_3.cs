using System;

public class Exercise_3
{
    public static void Run()
    {
        int n1, n2, n3, n4, n5;
        int sum;
        double avg;

        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        n5 = Convert.ToInt32(Console.ReadLine());

        sum = n1 + n2 + n3 + n4 + n5;
        avg = sum / 5.0;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + avg);
    }
}