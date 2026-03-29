using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Product Catalog");
        Console.WriteLine("2. Student Management");
        Console.WriteLine("3. Event Registration");
        Console.WriteLine("4. Undo Feature");
        Console.WriteLine("5. Hospital Queue");
        Console.WriteLine("6. Music Playlist");

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

            case 4:
                Assignment4.Run();
                break;

            case 5:
                Assignment5.Run();
                break;

            case 6:
                Assignment6.Run();
                break;
        }
    }
}