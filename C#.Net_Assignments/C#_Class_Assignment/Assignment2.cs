using System;

public class Assignment2
{
    public static void Run()
    {
        Doctor d1 = new Doctor();
        d1.DoctorId = 1;
        d1.DoctorName = "Dr. Ramesh";
        d1.Specialization = "Cardiology";
        d1.ConsultationFee = 500;

        Doctor d2 = new Doctor();
        d2.DoctorId = 2;
        d2.DoctorName = "Dr. Sita";
        d2.Specialization = "Dermatology";
        d2.ConsultationFee = 300;

        Console.WriteLine("Doctor 1:");
        Console.WriteLine(d1.DoctorName + " - " + d1.Specialization);

        Console.WriteLine("\nDoctor 2:");
        Console.WriteLine(d2.DoctorName + " - " + d2.Specialization);
    }
}

// Separate class
public class Doctor
{
    public int DoctorId;
    public string DoctorName;
    public string Specialization;
    public double ConsultationFee;
}