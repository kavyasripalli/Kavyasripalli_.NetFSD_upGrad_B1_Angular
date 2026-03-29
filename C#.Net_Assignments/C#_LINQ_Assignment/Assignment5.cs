using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public double Amount { get; set; }
}

class Assignment5
{
    public static void Run()
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1, Name="A"},
            new Customer{Id=2, Name="B"},
            new Customer{Id=3, Name="C"},
            new Customer{Id=4, Name="D"}
        };

        List<Order> orders = new List<Order>()
        {
            new Order{Id=1, CustomerId=1, Amount=2000},
            new Order{Id=2, CustomerId=1, Amount=4000},
            new Order{Id=3, CustomerId=2, Amount=3000},
            new Order{Id=4, CustomerId=3, Amount=1000}
        };

        Console.WriteLine("Join Customers and Orders:");
        var join = from c in customers
                   join o in orders
                   on c.Id equals o.CustomerId
                   select new { c.Name, o.Amount };

        foreach (var j in join)
            Console.WriteLine($"{j.Name} {j.Amount}");

        Console.WriteLine("\nTotal Amount per Customer:");
        var total = orders.GroupBy(o => o.CustomerId)
                          .Select(g => new { CustomerId = g.Key, Total = g.Sum(o => o.Amount) });

        foreach (var t in total)
        {
            var name = customers.First(c => c.Id == t.CustomerId).Name;
            Console.WriteLine($"{name} {t.Total}");
        }

        Console.WriteLine("\nCustomers with Total > 5000:");
        var high = total.Where(t => t.Total > 5000);

        foreach (var h in high)
        {
            var name = customers.First(c => c.Id == h.CustomerId).Name;
            Console.WriteLine($"{name} {h.Total}");
        }

        Console.WriteLine("\nCustomers with No Orders:");
        var noOrders = customers.Where(c => !orders.Any(o => o.CustomerId == c.Id));

        foreach (var c in noOrders)
            Console.WriteLine(c.Name);
    }
}