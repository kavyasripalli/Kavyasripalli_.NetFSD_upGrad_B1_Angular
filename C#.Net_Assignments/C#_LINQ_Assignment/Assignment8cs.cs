using System;
using System.Collections.Generic;
using System.Linq;

class Student2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public string Subject { get; set; }
    public int Marks { get; set; }
}

class Assignment8
{
    public static void Run()
    {
        List<Student2> students = new List<Student2>()
        {
            new Student2{Id=1, Name="A", Class="10", Subject="Math", Marks=80},
            new Student2{Id=2, Name="B", Class="10", Subject="Math", Marks=70},
            new Student2{Id=3, Name="C", Class="10", Subject="Science", Marks=90},
            new Student2{Id=4, Name="D", Class="9", Subject="Math", Marks=60},
            new Student2{Id=5, Name="E", Class="9", Subject="Science", Marks=75}
        };

        var result = students
            .GroupBy(s => s.Class)
            .Select(classGroup => new
            {
                Class = classGroup.Key,
                Subjects = classGroup
                    .GroupBy(s => s.Subject)
                    .Select(subjectGroup => new
                    {
                        Subject = subjectGroup.Key,
                        AvgMarks = subjectGroup.Average(s => s.Marks)
                    })
            });

        foreach (var c in result)
        {
            Console.WriteLine("Class: " + c.Class);

            foreach (var s in c.Subjects)
            {
                Console.WriteLine($"  {s.Subject} Avg: {s.AvgMarks}");
            }
        }
    }
}