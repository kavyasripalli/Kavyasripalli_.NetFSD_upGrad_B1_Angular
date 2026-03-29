using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose Exercise:");
        Console.WriteLine("1. Division");
        Console.WriteLine("2. KM to Meters");
        Console.WriteLine("3. Sum and Average");
        Console.WriteLine("4. Odd or Even");
        Console.WriteLine("5. Highest of Two Numbers");
        Console.WriteLine("6. Area of Rectangle and Square");
        Console.WriteLine("7. Time Calculation (Distance / Speed)");
        Console.WriteLine("8. Check 3rd Character (Vowel/Consonant)");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Exercise_1.Run();
                break;

            case 2:
                Exercise_2.Run();
                break;

            case 3:
                Exercise_3.Run();
                break;

            case 4:
                Exercise_4.Run();
                break;

            case 5:
                Exercise_5.Run();
                break;

            case 6:
                Exercise_6.Run();
                break;

            case 7:
                Exercise7.Run();
                break;

            case 8:
                Exercise_8.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}