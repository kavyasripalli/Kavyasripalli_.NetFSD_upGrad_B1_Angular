using System;

public class Exercise2
{
    public static void Run(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No username provided");
        }
        else
        {
            string username = args[0];

            Console.WriteLine("Hi! " + username);
            Console.WriteLine("Welcome to the world of C#");
        }
    }
}