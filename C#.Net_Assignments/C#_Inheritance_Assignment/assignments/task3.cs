using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;

class Order
{
    public int OrderId { get; set; }
    public double OrderAmount { get; set; }

    public Order(int id, double amount)
    {
        OrderId = id;
        OrderAmount = amount;
    }

    // Virtual method
    public virtual double CalculateShippingCost()
    {
        return 50; // default shipping
    }
}

class StandardOrder : Order
{
    public StandardOrder(int id, double amount) : base(id, amount) { }

    public override double CalculateShippingCost()
    {
        return 50;
    }
}

class ExpressOrder : Order
{
    public ExpressOrder(int id, double amount) : base(id, amount) { }

    public override double CalculateShippingCost()
    {
        return 100;
    }
}

class InternationalOrder : Order
{
    public InternationalOrder(int id, double amount) : base(id, amount) { }

    public override double CalculateShippingCost()
    {
        return 500;
    }
}

class task3
{
    static void Main()
    {
        List<Order> orders = new List<Order>();

        orders.Add(new StandardOrder(1, 1000));
        orders.Add(new ExpressOrder(2, 2000));
        orders.Add(new InternationalOrder(3, 5000));

        foreach (Order order in orders)
        {
            Console.WriteLine(
                "Order ID: " + order.OrderId +
                " | Shipping Cost: " + order.CalculateShippingCost()
            );
        }
    }
}