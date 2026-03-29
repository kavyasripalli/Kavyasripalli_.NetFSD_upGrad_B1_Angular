using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

class Assignment7
{
    public static void Run()
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Category="Electronics", Price=50000, Stock=5},
            new Product{Id=2, Name="Phone", Category="Electronics", Price=20000, Stock=15},
            new Product{Id=3, Name="Shoes", Category="Fashion", Price=3000, Stock=8},
            new Product{Id=4, Name="Watch", Category="Accessories", Price=5000, Stock=0},
            new Product{Id=5, Name="Chair", Category="Furniture", Price=4000, Stock=12}
        };

        Console.WriteLine("Stock < 10:");
        var lowStock = products.Where(p => p.Stock < 10);
        foreach (var p in lowStock)
            Console.WriteLine($"{p.Name} {p.Stock}");

        Console.WriteLine("\nTop 3 Expensive:");
        var top3 = products.OrderByDescending(p => p.Price).Take(3);
        foreach (var p in top3)
            Console.WriteLine($"{p.Name} {p.Price}");

        Console.WriteLine("\nGroup by Category:");
        var groups = products.GroupBy(p => p.Category);
        foreach (var g in groups)
        {
            Console.WriteLine(g.Key);
            foreach (var p in g)
                Console.WriteLine(" " + p.Name);
        }

        Console.WriteLine("\nTotal Stock per Category:");
        var totalStock = products.GroupBy(p => p.Category)
                                 .Select(g => new { Category = g.Key, Total = g.Sum(p => p.Stock) });

        foreach (var t in totalStock)
            Console.WriteLine($"{t.Category} {t.Total}");

        Console.WriteLine("\nAny Out of Stock:");
        bool anyZero = products.Any(p => p.Stock == 0);
        Console.WriteLine(anyZero);
    }
}