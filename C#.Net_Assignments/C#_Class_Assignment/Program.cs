using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Assignment 1 (Patient)");
        Console.WriteLine("2. Assignment 2 (Doctor)");
        Console.WriteLine("3. Static Variables (Hospital)");
        Console.WriteLine("4. Default Constructor (Appointment)");
        Console.WriteLine("5. Parameterized Constructor (Medical Test)");
        Console.WriteLine("6. Billing (Methods)");
        Console.WriteLine("7. Properties (Nurse)");
        Console.WriteLine("8. Mini Healthcare System");

        int choice = Convert.ToInt32(Console.ReadLine());

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

            case 7:
                Assignment7.Run();
                break;

            case 8:
                Assignment8.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}