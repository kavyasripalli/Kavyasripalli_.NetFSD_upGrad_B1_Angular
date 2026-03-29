using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Govt Rules (Interface)");
        Console.WriteLine("2. Sales System");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Assignment1.Run();
                break;

            case 2:
                Assignment2.Run();
                break;
        }
    }
}