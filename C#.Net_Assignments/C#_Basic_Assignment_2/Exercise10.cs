using System;

public class Exercise10
{
    public static void Run()
    {
        int a = 0, b = 1, next;

        Console.WriteLine("Fibonacci series up to 40:");

        Console.Write(a + " " + b + " ");

        while (true)
        {
            next = a + b;

            if (next > 40)
                break;

            Console.Write(next + " ");

            a = b;
            b = next;
        }
    }
}