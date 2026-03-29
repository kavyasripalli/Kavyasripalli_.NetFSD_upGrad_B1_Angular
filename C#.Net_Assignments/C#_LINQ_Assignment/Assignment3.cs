using System;
using System.Collections.Generic;
using System.Linq;

class Assignment3
{
    public static void Run()
    {
        List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

        Console.WriteLine("Names starting with A:");
        var aNames = names.Where(n => n.StartsWith("A"));
        foreach (var n in aNames)
            Console.WriteLine(n);

        Console.WriteLine("\nSorted Names:");
        var sorted = names.OrderBy(n => n);
        foreach (var n in sorted)
            Console.WriteLine(n);

        Console.WriteLine("\nUppercase Names:");
        var upper = names.Select(n => n.ToUpper());
        foreach (var n in upper)
            Console.WriteLine(n);

        Console.WriteLine("\nNames length > 4:");
        var longNames = names.Where(n => n.Length > 4);
        foreach (var n in longNames)
            Console.WriteLine(n);
    }
}