using System;

public class Assignment5
{
    public static void Run()
    {
        MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
        MedicalTest t2 = new MedicalTest(2, "X-Ray", 800);

        Console.WriteLine("Test 1:");
        t1.Display();

        Console.WriteLine();

        Console.WriteLine("Test 2:");
        t2.Display();
    }
}

public class MedicalTest
{
    public int TestId;
    public string TestName;
    public double TestCost;

    public MedicalTest(int id, string name, double cost)
    {
        TestId = id;
        TestName = name;
        TestCost = cost;
    }

    public void Display()
    {
        Console.WriteLine("Test Id: " + TestId);
        Console.WriteLine("Test Name: " + TestName);
        Console.WriteLine("Test Cost: " + TestCost);
    }
}