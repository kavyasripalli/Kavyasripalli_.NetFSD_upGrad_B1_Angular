using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Employee Log System");
        Console.WriteLine("2. Student Report System");
        Console.WriteLine("3. Mini Notepad");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Assignment1.Run();
                break;

            case 2:
                Assignment2.Run();
                break;

            case 3:
                Assignment3.Run();
                break;
        }
    }
}