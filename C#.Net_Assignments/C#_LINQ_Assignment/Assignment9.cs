using System;
using System.Collections.Generic;
using System.Linq;

class Order2
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public double TotalAmount { get; set; }
}

class Assignment9
{
    public static void Run()
    {
        List<Order2> orders = new List<Order2>()
        {
            new Order2{Id=1, CustomerName="A", OrderDate=DateTime.Now.AddDays(-10), TotalAmount=2000},
            new Order2{Id=2, CustomerName="B", OrderDate=DateTime.Now.AddDays(-40), TotalAmount=3000},
            new Order2{Id=3, CustomerName="A", OrderDate=DateTime.Now.AddDays(-5), TotalAmount=4000},
            new Order2{Id=4, CustomerName="C", OrderDate=DateTime.Now.AddDays(-20), TotalAmount=5000},
            new Order2{Id=5, CustomerName="D", OrderDate=DateTime.Now.AddDays(-2), TotalAmount=6000},
            new Order2{Id=6, CustomerName="B", OrderDate=DateTime.Now.AddDays(-15), TotalAmount=2500}
        };

        Console.WriteLine("Orders in Last 30 Days:");
        var recent = orders.Where(o => o.OrderDate >= DateTime.Now.AddDays(-30));
        foreach (var o in recent)
            Console.WriteLine($"{o.CustomerName} {o.TotalAmount}");

        Console.WriteLine("\nMonthly Sales Report:");
        var monthly = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                            .Select(g => new
                            {
                                g.Key.Year,
                                g.Key.Month,
                                Total = g.Sum(o => o.TotalAmount)
                            });

        foreach (var m in monthly)
            Console.WriteLine($"{m.Month}/{m.Year} -> {m.Total}");

        Console.WriteLine("\nTop 5 Customers:");
        var top = orders.GroupBy(o => o.CustomerName)
                        .Select(g => new
                        {
                            Customer = g.Key,
                            Total = g.Sum(o => o.TotalAmount)
                        })
                        .OrderByDescending(x => x.Total)
                        .Take(5);

        foreach (var t in top)
            Console.WriteLine($"{t.Customer} {t.Total}");

        Console.WriteLine("\nHighest Order per Month:");
        var highest = orders.GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                            .Select(g => g.OrderByDescending(o => o.TotalAmount).First());

        foreach (var h in highest)
            Console.WriteLine($"{h.CustomerName} {h.TotalAmount} ({h.OrderDate.Month})");
    }
}