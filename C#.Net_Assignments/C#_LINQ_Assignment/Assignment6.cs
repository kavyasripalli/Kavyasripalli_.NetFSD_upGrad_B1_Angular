using System;
using System.Collections.Generic;
using System.Linq;

class Assignment6
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

        Console.WriteLine("Remove Duplicates:");
        var unique = numbers.Distinct();
        foreach (var n in unique)
            Console.WriteLine(n);

        Console.WriteLine("\nDuplicate Values:");
        var duplicates = numbers.GroupBy(n => n)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

        foreach (var n in duplicates)
            Console.WriteLine(n);

        Console.WriteLine("\nCount Occurrence:");
        var count = numbers.GroupBy(n => n)
                           .Select(g => new { Number = g.Key, Count = g.Count() });

        foreach (var c in count)
            Console.WriteLine($"{c.Number} -> {c.Count}");
    }
}