using System;

public class Assignment6
{
    public static void Run()
    {
        Billing b1 = new Billing();

        b1.PatientName = "Ramesh";
        b1.ConsultationFee = 1000;
        b1.TestCharges = 500;

        b1.CalculateTotalBill();
    }
}

public class Billing
{
    public string PatientName;
    public double ConsultationFee;
    public double TestCharges;
    public void CalculateTotalBill()
    {
        double total = ConsultationFee + TestCharges;

        Console.WriteLine("Patient Name: " + PatientName);
        Console.WriteLine("Total Bill: " + total);
    }
}