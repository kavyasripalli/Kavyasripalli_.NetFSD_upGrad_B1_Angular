using System;
using System.Threading;

class BankAccount
{
    public int Balance = 1000;

    // without lock
    public void WithdrawWithoutLock(int amount)
    {
        if (Balance >= amount)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " withdrawing " + amount);
            Balance -= amount;
            Console.WriteLine("Remaining Balance: " + Balance);
        }
        else
        {
            Console.WriteLine(Thread.CurrentThread.Name + " insufficient balance");
        }
    }

    // with lock
    object obj = new object();

    public void WithdrawWithLock(int amount)
    {
        lock (obj)
        {
            if (Balance >= amount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " withdrawing " + amount);
                Balance -= amount;
                Console.WriteLine("Remaining Balance: " + Balance);
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " insufficient balance");
            }
        }
    }
}

class Assignment2
{
    public static void Run()
    {
        Console.WriteLine("1. Without Lock");
        Console.WriteLine("2. With Lock");

        int choice = int.Parse(Console.ReadLine());

        BankAccount acc = new BankAccount();

        Thread t1, t2, t3;

        if (choice == 1)
        {
            t1 = new Thread(() => acc.WithdrawWithoutLock(700)) { Name = "T1" };
            t2 = new Thread(() => acc.WithdrawWithoutLock(700)) { Name = "T2" };
            t3 = new Thread(() => acc.WithdrawWithoutLock(700)) { Name = "T3" };
        }
        else
        {
            t1 = new Thread(() => acc.WithdrawWithLock(700)) { Name = "T1" };
            t2 = new Thread(() => acc.WithdrawWithLock(700)) { Name = "T2" };
            t3 = new Thread(() => acc.WithdrawWithLock(700)) { Name = "T3" };
        }

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Final Balance: " + acc.Balance);
    }
}