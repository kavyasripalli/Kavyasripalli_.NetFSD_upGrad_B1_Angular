using System;

class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public void CalculateInterest()
    {
        Console.WriteLine("Base account interest calculation");
    }
}

// savings
class SavingsAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Savings account interest calculation");
    }
}

// current
class CurrentAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Current account interest calculation");
    }
}

class Assignment2
{
    public static void Run()
    {
        Account acc = new SavingsAccount();
        acc.CalculateInterest();

        Account acc2 = new CurrentAccount();
        acc2.CalculateInterest();
    }
}