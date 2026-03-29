using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Parallel Number Processing");
        Console.WriteLine("2. Bank Account (Synchronization)");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Assignment1.Run();
                break;

            case 2:
                Assignment2.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}