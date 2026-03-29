using System;

public class Assignment7
{
    public static void Run()
    {
        Nurse n1 = new Nurse
        {
            NurseId = 101,
            NurseName = "Anjali",
            Department = "ICU"
        };

        Console.WriteLine("Nurse Id: " + n1.NurseId);
        Console.WriteLine("Nurse Name: " + n1.NurseName);
        Console.WriteLine("Department: " + n1.Department);
    }
}

public class Nurse
{
    public int NurseId { get; set; }
    public string NurseName { get; set; }
    public string Department { get; set; }
}