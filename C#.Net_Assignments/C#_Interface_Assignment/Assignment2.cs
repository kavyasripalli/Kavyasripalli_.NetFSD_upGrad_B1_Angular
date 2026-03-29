using System;

abstract class Sales
{
    protected int dailySales = 400;

    public int GetDailySales()
    {
        return dailySales;
    }

    public abstract int GetMonthlySales();
}

interface ISales
{
    int GetYearlySales();
}

class SalesReport : Sales, ISales
{
    public override int GetMonthlySales()
    {
        return dailySales * 30;
    }

    public int GetYearlySales()
    {
        return dailySales * 30 * 12;
    }
}

class Assignment2
{
    public static void Run()
    {
        SalesReport s = new SalesReport();

        Console.WriteLine("Daily sales: Rs." + s.GetDailySales());
        Console.WriteLine("Monthly sales: Rs." + s.GetMonthlySales());
        Console.WriteLine("Annual sales: Rs." + s.GetYearlySales());
    }
}