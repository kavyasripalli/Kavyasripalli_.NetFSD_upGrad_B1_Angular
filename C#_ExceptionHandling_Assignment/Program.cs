using System;

// custom exception
class CheckBalanceException : Exception
{
    public CheckBalanceException(string message) : base(message) { }
}

class BankAccount
{
    public int AccountNumber { get; set; }
    public string Name { get; set; }
    public static double Balance = 1000;

    public char TransactionType { get; set; }
    public double TransactionAmount { get; set; }

    public void ProcessTransaction()
    {
        if (TransactionType == 'd') // deposit
        {
            Balance += TransactionAmount;
            Console.WriteLine("Deposited: " + TransactionAmount);
        }
        else if (TransactionType == 'c') // withdrawal
        {
            if (Balance - TransactionAmount < 500)
            {
                throw new CheckBalanceException("Minimum balance should be 500");
            }

            Balance -= TransactionAmount;
            Console.WriteLine("Withdrawn: " + TransactionAmount);
        }

        Console.WriteLine("Current Balance: " + Balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount();

        Console.Write("Account Number: ");
        acc.AccountNumber = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        acc.Name = Console.ReadLine();

        Console.Write("Transaction Type (d/c): ");
        acc.TransactionType = char.Parse(Console.ReadLine());

        Console.Write("Amount: ");
        acc.TransactionAmount = double.Parse(Console.ReadLine());

        try
        {
            acc.ProcessTransaction();
        }
        catch (CheckBalanceException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}