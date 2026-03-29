using System;

public class Assignment3
{
    public static void Run()
    {
        Hospital.HospitalName = "Apollo Hospital";
        Hospital.HospitalAddress = "Hyderabad";

        Hospital p1 = new Hospital();
        p1.PatientName = "Ravi";

        Hospital p2 = new Hospital();
        p2.PatientName = "Neha";

        Hospital p3 = new Hospital();
        p3.PatientName = "Rahul";

        p1.Display();
        Console.WriteLine();

        p2.Display();
        Console.WriteLine();

        p3.Display();
    }
}

public class Hospital
{
    public static string HospitalName;
    public static string HospitalAddress;

    public string PatientName;

    public void Display()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Hospital Address: " + HospitalAddress);
        Console.WriteLine("Patient Name: " + PatientName);
    }
}