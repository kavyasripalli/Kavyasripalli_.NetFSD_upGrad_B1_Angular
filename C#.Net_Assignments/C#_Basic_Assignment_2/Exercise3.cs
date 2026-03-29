using System;

public class Exercise3
{
    public static void Run(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide two numbers");
            return;
        }

        int num1, num2;

        if (!int.TryParse(args[0], out num1) || !int.TryParse(args[1], out num2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);

        Console.WriteLine("Numbers between " + start + " and " + end + ":");

        for (int i = start + 1; i < end; i++)
        {
            Console.Write(i + " ");
        }
    }
}