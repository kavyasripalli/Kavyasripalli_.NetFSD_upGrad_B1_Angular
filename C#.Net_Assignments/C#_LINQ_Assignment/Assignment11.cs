using System;
using System.Collections.Generic;
using System.Linq;

class Employee3
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
    public DateTime JoiningDate { get; set; }
}

class Assignment11
{
    public static void Run()
    {
        List<Employee3> employees = new List<Employee3>()
        {
            new Employee3{Id=1, Name="A", Department="IT", Salary=50000, JoiningDate=DateTime.Now.AddMonths(-2)},
            new Employee3{Id=2, Name="B", Department="HR", Salary=40000, JoiningDate=DateTime.Now.AddMonths(-8)},
            new Employee3{Id=3, Name="C", Department="IT", Salary=70000, JoiningDate=DateTime.Now.AddMonths(-1)},
            new Employee3{Id=4, Name="D", Department="Finance", Salary=60000, JoiningDate=DateTime.Now.AddMonths(-5)},
            new Employee3{Id=5, Name="E", Department="HR", Salary=45000, JoiningDate=DateTime.Now.AddMonths(-3)}
        };

        Console.WriteLine("Total Employees:");
        Console.WriteLine(employees.Count());

        Console.WriteLine("\nDepartment-wise Average Salary:");
        var avg = employees.GroupBy(e => e.Department)
                           .Select(g => new
                           {
                               Dept = g.Key,
                               AvgSalary = g.Average(e => e.Salary)
                           });

        foreach (var a in avg)
            Console.WriteLine($"{a.Dept} {a.AvgSalary}");

        Console.WriteLine("\nRecently Joined (Last 6 Months):");
        var recent = employees.Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6));
        foreach (var r in recent)
            Console.WriteLine($"{r.Name} {r.JoiningDate}");

        Console.WriteLine("\nHighest Paid per Department:");
        var highest = employees.GroupBy(e => e.Department)
                               .Select(g => g.OrderByDescending(e => e.Salary).First());

        foreach (var h in highest)
            Console.WriteLine($"{h.Department} {h.Name} {h.Salary}");

        Console.WriteLine("\nSalary Distribution:");
        Console.WriteLine("Min: " + employees.Min(e => e.Salary));
        Console.WriteLine("Max: " + employees.Max(e => e.Salary));
        Console.WriteLine("Avg: " + employees.Average(e => e.Salary));
    }
}