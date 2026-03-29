using System;
using System.Linq;

public class Exercise15
{
    public static void Run()
    {
        int[] marks = new int[10];
        int total = 0;

        Console.WriteLine("Enter 10 marks:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Mark " + (i + 1) + ": ");

            if (!int.TryParse(Console.ReadLine(), out marks[i]))
            {
                Console.WriteLine("Invalid input");
                i--;
            }
        }

        // Total
        total = marks.Sum();

        // Average
        double avg = total / 10.0;

        // Min & Max
        int min = marks.Min();
        int max = marks.Max();

        // Ascending
        Array.Sort(marks);

        Console.WriteLine("\nTotal = " + total);
        Console.WriteLine("Average = " + avg);
        Console.WriteLine("Minimum = " + min);
        Console.WriteLine("Maximum = " + max);

        Console.WriteLine("\nAscending Order:");
        foreach (int m in marks)
        {
            Console.Write(m + " ");
        }

        // Descending
        Array.Reverse(marks);

        Console.WriteLine("\n\nDescending Order:");
        foreach (int m in marks)
        {
            Console.Write(m + " ");
        }
    }
}