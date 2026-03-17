using System;
using System.Collections.Generic;
using System.Text;

using System;

class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public Account(int accNo, double balance)
    {
        AccountNumber = accNo;
        Balance = balance;
    }

    public void CalculateInterest()
    {
        Console.WriteLine("Base account interest calculation");
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(int accNo, double balance)
        : base(accNo, balance)
    {
    }

    // Method Hiding
    public new void CalculateInterest()
    {
        Console.WriteLine("Savings Account Interest Calculation");
    }
}

class CurrentAccount : Account
{
    public CurrentAccount(int accNo, double balance)
        : base(accNo, balance)
    {
    }

    // Method Hiding
    public new void CalculateInterest()
    {
        Console.WriteLine("Current Account Interest Calculation");
    }
}

class task2
{
    static void Main(string[] args)
    {
        Account acc = new SavingsAccount(101, 50000);

        acc.CalculateInterest();   // Calls base class method

        SavingsAccount sav = new SavingsAccount(102, 70000);
        sav.CalculateInterest();   // Calls derived class method
    }
}