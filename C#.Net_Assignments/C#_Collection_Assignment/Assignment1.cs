using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

class Assignment1
{
    public static void Run()
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Price=50000, Category="Electronics"},
            new Product{Id=2, Name="Phone", Price=20000, Category="Electronics"},
            new Product{Id=3, Name="Shoes", Price=1500, Category="Fashion"},
            new Product{Id=4, Name="Watch", Price=3000, Category="Accessories"},
            new Product{Id=5, Name="Bag", Price=1200, Category="Fashion"},
            new Product{Id=6, Name="Tablet", Price=25000, Category="Electronics"},
            new Product{Id=7, Name="Headphones", Price=800, Category="Electronics"},
            new Product{Id=8, Name="Chair", Price=4000, Category="Furniture"},
            new Product{Id=9, Name="Desk", Price=7000, Category="Furniture"},
            new Product{Id=10, Name="Camera", Price=45000, Category="Electronics"}
        };

        // display all
        Console.WriteLine("All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Id} {p.Name} {p.Price} {p.Category}");

        Console.WriteLine("\nPrice > 1000:");
        var costly = products.Where(p => p.Price > 1000);
        foreach (var p in costly)
            Console.WriteLine(p.Name + " " + p.Price);

        Console.WriteLine("\nSort Asc:");
        var asc = products.OrderBy(p => p.Price);
        foreach (var p in asc)
            Console.WriteLine(p.Name + " " + p.Price);

        Console.WriteLine("\nSort Desc:");
        var desc = products.OrderByDescending(p => p.Price);
        foreach (var p in desc)
            Console.WriteLine(p.Name + " " + p.Price);

        // remove by id
        products.RemoveAll(p => p.Id == 3);

        Console.WriteLine("\nAfter Removing Id=3:");
        foreach (var p in products)
            Console.WriteLine(p.Name);

        Console.WriteLine("\nFilter Category = Electronics:");
        var category = products.Where(p => p.Category == "Electronics");
        foreach (var p in category)
            Console.WriteLine(p.Name);
    }
}