using System;

public class Exercise_4
{
    public static void Run()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

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