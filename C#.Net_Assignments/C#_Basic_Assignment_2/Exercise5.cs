using System;

public class Exercise5
{
    public static void Run()
    {
        int n, num;
        int evenCount = 0, oddCount = 0;

        Console.Write("How many numbers do you want to enter? ");

        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number " + i + ": ");

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Invalid input, try again");
                i--; // retry same iteration
                continue;
            }

            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Total Even Numbers = " + evenCount);
        Console.WriteLine("Total Odd Numbers = " + oddCount);
    }
}