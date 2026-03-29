using System;
using System.Collections.Generic;
using System.Linq;

class Student1
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Assignment1
{
    public static void Run()
    {
        List<Student1> students = new List<Student1>()
        {
            new Student1{Id=1, Name="A", Age=20, Marks=80},
            new Student1{Id=2, Name="B", Age=17, Marks=60},
            new Student1{Id=3, Name="C", Age=22, Marks=90},
            new Student1{Id=4, Name="D", Age=25, Marks=70},
            new Student1{Id=5, Name="E", Age=19, Marks=85}
        };

        Console.WriteLine("Marks > 75:");
        var high = students.Where(s => s.Marks > 75);
        foreach (var s in high)
            Console.WriteLine($"{s.Name} {s.Marks}");

        Console.WriteLine("\nAge between 18 and 25:");
        var age = students.Where(s => s.Age >= 18 && s.Age <= 25);
        foreach (var s in age)
            Console.WriteLine($"{s.Name} {s.Age}");

        Console.WriteLine("\nSort by Marks Desc:");
        var sorted = students.OrderByDescending(s => s.Marks);
        foreach (var s in sorted)
            Console.WriteLine($"{s.Name} {s.Marks}");

        Console.WriteLine("\nSelect Name and Marks:");
        var select = students.Select(s => new { s.Name, s.Marks });
        foreach (var s in select)
            Console.WriteLine($"{s.Name} {s.Marks}");
    }
}