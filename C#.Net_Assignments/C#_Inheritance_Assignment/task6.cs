using System;
using System.Collections.Generic;
using System.Text;

using System;

class Furniture
{
    public int OrderId;
    public string OrderDate;
    public string FurnitureType;
    public int Qty;
    public double TotalAmt;
    public string PaymentMode;

    public virtual void GetData()
    {
        Console.Write("Enter Order Id: ");
        OrderId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Order Date: ");
        OrderDate = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        Qty = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Payment Mode (Credit/Debit): ");
        PaymentMode = Console.ReadLine();
    }

    public virtual void ShowData()
    {
        Console.WriteLine("\nOrder Id: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Quantity: " + Qty);
        Console.WriteLine("Payment Mode: " + PaymentMode);
        Console.WriteLine("Total Amount: " + TotalAmt);
    }
}

class Chair : Furniture
{
    public string ChairType;
    public string Purpose;
    public string MaterialType;
    public double Rate;

    public override void GetData()
    {
        base.GetData();

        FurnitureType = "Chair";

        Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
        ChairType = Console.ReadLine();

        Console.Write("Enter Purpose (Home/Office): ");
        Purpose = Console.ReadLine();

        if (ChairType == "Wood")
        {
            Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
            MaterialType = Console.ReadLine();
        }
        else if (ChairType == "Steel")
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown Steel): ");
            MaterialType = Console.ReadLine();
        }
        else if (ChairType == "Plastic")
        {
            Console.Write("Enter Plastic Color (Green/Red/Blue/White): ");
            MaterialType = Console.ReadLine();
        }

        Console.Write("Enter Rate: ");
        Rate = Convert.ToDouble(Console.ReadLine());

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();

        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Chair Type: " + ChairType);
        Console.WriteLine("Purpose: " + Purpose);
        Console.WriteLine("Material Type: " + MaterialType);
        Console.WriteLine("Rate: " + Rate);
    }
}

class Cot : Furniture
{
    public string CotType;
    public string MaterialType;
    public string Capacity;
    public double Rate;

    public override void GetData()
    {
        base.GetData();

        FurnitureType = "Cot";

        Console.Write("Enter Cot Type (Wood/Steel): ");
        CotType = Console.ReadLine();

        if (CotType == "Wood")
        {
            Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
            MaterialType = Console.ReadLine();
        }
        else if (CotType == "Steel")
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown Steel): ");
            MaterialType = Console.ReadLine();
        }

        Console.Write("Enter Capacity (Single/Double): ");
        Capacity = Console.ReadLine();

        Console.Write("Enter Rate: ");
        Rate = Convert.ToDouble(Console.ReadLine());

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();

        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Cot Type: " + CotType);
        Console.WriteLine("Material Type: " + MaterialType);
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Rate: " + Rate);
    }
}

class task6
{
    static void Main()
    {
        Console.WriteLine("Select Furniture Type");
        Console.WriteLine("1. Chair");
        Console.WriteLine("2. Cot");

        int choice = Convert.ToInt32(Console.ReadLine());

        Furniture f;

        if (choice == 1)
            f = new Chair();
        else
            f = new Cot();

        f.GetData();
        f.ShowData();
    }
}
