using System;

class Furniture
{
    public int OrderId { get; set; }
    public string OrderDate { get; set; }
    public string FurnitureType { get; set; }
    public int Qty { get; set; }
    public double TotalAmt { get; set; }
    public string PaymentMode { get; set; }

    public virtual void GetData()
    {
        Console.Write("OrderId: ");
        OrderId = int.Parse(Console.ReadLine());

        Console.Write("OrderDate: ");
        OrderDate = Console.ReadLine();

        Console.Write("FurnitureType (Chair/Cot): ");
        FurnitureType = Console.ReadLine();

        Console.Write("Qty: ");
        Qty = int.Parse(Console.ReadLine());

        Console.Write("PaymentMode: ");
        PaymentMode = Console.ReadLine();
    }

    public virtual void ShowData()
    {
        Console.WriteLine("OrderId: " + OrderId);
        Console.WriteLine("OrderDate: " + OrderDate);
        Console.WriteLine("FurnitureType: " + FurnitureType);
        Console.WriteLine("Qty: " + Qty);
        Console.WriteLine("PaymentMode: " + PaymentMode);
        Console.WriteLine("Total Amount: " + TotalAmt);
    }
}

// chair
class Chair : Furniture
{
    public string ChairType { get; set; }
    public string Purpose { get; set; }
    public string MaterialDetail { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();

        Console.Write("ChairType (Wood/Steel/Plastic): ");
        ChairType = Console.ReadLine();

        Console.Write("Purpose (Home/Office): ");
        Purpose = Console.ReadLine();

        Console.Write("Material Detail: ");
        MaterialDetail = Console.ReadLine();

        Console.Write("Rate: ");
        Rate = double.Parse(Console.ReadLine());

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine("ChairType: " + ChairType);
        Console.WriteLine("Purpose: " + Purpose);
        Console.WriteLine("Material: " + MaterialDetail);
        Console.WriteLine("Rate: " + Rate);
    }
}

// cot
class Cot : Furniture
{
    public string CotType { get; set; }
    public string MaterialDetail { get; set; }
    public string Capacity { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();

        Console.Write("CotType (Wood/Steel): ");
        CotType = Console.ReadLine();

        Console.Write("Material Detail: ");
        MaterialDetail = Console.ReadLine();

        Console.Write("Capacity (Single/Double): ");
        Capacity = Console.ReadLine();

        Console.Write("Rate: ");
        Rate = double.Parse(Console.ReadLine());

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine("CotType: " + CotType);
        Console.WriteLine("Material: " + MaterialDetail);
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Rate: " + Rate);
    }
}

class Assignment6
{
    public static void Run()
    {
        Console.Write("Enter Furniture Type (1-Chair, 2-Cot): ");
        int choice = int.Parse(Console.ReadLine());

        Furniture f;

        if (choice == 1)
            f = new Chair();
        else
            f = new Cot();

        f.GetData();
        f.ShowData();
    }
}