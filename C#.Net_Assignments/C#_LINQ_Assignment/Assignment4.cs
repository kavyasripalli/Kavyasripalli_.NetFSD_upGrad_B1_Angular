using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Assignment4
{
    public static void Run()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=1, Name="A", Department="IT", Salary=50000},
            new Employee{Id=2, Name="B", Department="HR", Salary=40000},
            new Employee{Id=3, Name="C", Department="IT", Salary=70000},
            new Employee{Id=4, Name="D", Department="Finance", Salary=60000},
            new Employee{Id=5, Name="E", Department="HR", Salary=45000}
        };

        Console.WriteLine("IT Employees:");
        var itEmp = employees.Where(e => e.Department == "IT");
        foreach (var e in itEmp)
            Console.WriteLine(e.Name);

        Console.WriteLine("\nHighest Salary:");
        var maxEmp = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"{maxEmp.Name} {maxEmp.Salary}");

        Console.WriteLine("\nAverage Salary:");
        var avg = employees.Average(e => e.Salary);
        Console.WriteLine(avg);

        Console.WriteLine("\nGroup by Department:");
        var groups = employees.GroupBy(e => e.Department);
        foreach (var g in groups)
        {
            Console.WriteLine(g.Key);
            foreach (var e in g)
                Console.WriteLine(" " + e.Name);
        }

        Console.WriteLine("\nCount per Department:");
        var count = employees.GroupBy(e => e.Department)
                             .Select(g => new { Dept = g.Key, Count = g.Count() });

        foreach (var c in count)
            Console.WriteLine($"{c.Dept} {c.Count}");
    }
}