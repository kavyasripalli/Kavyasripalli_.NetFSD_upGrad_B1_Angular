using System;
using System.Collections.Generic;
using System.Linq;

class Assignment2
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

        Console.WriteLine("Even Numbers:");
        var even = numbers.Where(n => n % 2 == 0);
        foreach (var n in even)
            Console.WriteLine(n);

        Console.WriteLine("\nNumbers > 15:");
        var greater = numbers.Where(n => n > 15);
        foreach (var n in greater)
            Console.WriteLine(n);

        Console.WriteLine("\nSquare of Numbers:");
        var square = numbers.Select(n => n * n);
        foreach (var n in square)
            Console.WriteLine(n);

        Console.WriteLine("\nCount divisible by 5:");
        int count = numbers.Count(n => n % 5 == 0);
        Console.WriteLine(count);
    }
}