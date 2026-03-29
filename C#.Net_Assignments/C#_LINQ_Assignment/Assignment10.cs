using System;
using System.Collections.Generic;
using System.Linq;

class Employee2
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Assignment10
{
    public static void Run()
    {
        List<Employee2> employees = new List<Employee2>()
        {
            new Employee2{Id=1, Name="A", Department="IT", Salary=50000},
            new Employee2{Id=2, Name="B", Department="HR", Salary=40000},
            new Employee2{Id=3, Name="C", Department="IT", Salary=70000},
            new Employee2{Id=4, Name="D", Department="Finance", Salary=60000},
            new Employee2{Id=5, Name="E", Department="HR", Salary=45000}
        };

        Console.WriteLine("Custom Sorted Employees:");

        var sorted = employees
                        .OrderBy(e => e.Department)
                        .ThenByDescending(e => e.Salary);

        foreach (var e in sorted)
            Console.WriteLine($"{e.Department} {e.Name} {e.Salary}");
    }
}