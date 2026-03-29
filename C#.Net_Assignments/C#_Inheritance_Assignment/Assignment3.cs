using System;
using System.Collections.Generic;

class Order
{
    public int OrderId { get; set; }
    public double OrderAmount { get; set; }

    public virtual double CalculateShippingCost()
    {
        return 50;
    }
}

// standard
class StandardOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 50;
    }
}

// express
class ExpressOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 100;
    }
}

// international
class InternationalOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 500;
    }
}

class Assignment3
{
    public static void Run()
    {
        List<Order> orders = new List<Order>()
        {
            new StandardOrder { OrderId = 1, OrderAmount = 1000 },
            new ExpressOrder { OrderId = 2, OrderAmount = 2000 },
            new InternationalOrder { OrderId = 3, OrderAmount = 3000 }
        };

        foreach (Order order in orders)
        {
            Console.WriteLine("OrderId: " + order.OrderId);
            Console.WriteLine("Shipping Cost: " + order.CalculateShippingCost());
            Console.WriteLine("-------------------");
        }
    }
}