using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Assignment2
{
    public static void Run()
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            {1, new Student{Id=1, Name="A", Marks=80}},
            {2, new Student{Id=2, Name="B", Marks=60}},
            {3, new Student{Id=3, Name="C", Marks=90}},
            {4, new Student{Id=4, Name="D", Marks=70}},
            {5, new Student{Id=5, Name="E", Marks=85}}
        };

        // retrieve by id
        Console.WriteLine("Student with Id=3:");
        if (students.ContainsKey(3))
        {
            var s = students[3];
            Console.WriteLine($"{s.Name} {s.Marks}");
        }

        // check exists
        Console.WriteLine("\nCheck Id=2 exists:");
        Console.WriteLine(students.ContainsKey(2));

        // update marks
        students[2].Marks = 75;
        Console.WriteLine("\nUpdated Marks for Id=2: " + students[2].Marks);

        // remove student
        students.Remove(4);
        Console.WriteLine("\nAfter removing Id=4:");

        foreach (var s in students.Values)
            Console.WriteLine($"{s.Id} {s.Name} {s.Marks}");

        // bonus
        Console.WriteLine("\nMarks > 75:");
        var high = students.Values.Where(s => s.Marks > 75);
        foreach (var s in high)
            Console.WriteLine($"{s.Name} {s.Marks}");
    }
}