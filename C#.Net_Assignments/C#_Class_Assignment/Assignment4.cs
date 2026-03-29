using System;

public class Assignment4
{
    public static void Run()
    {
        // Create object
        Appointment a1 = new Appointment();

        // Assign remaining values
        a1.AppointmentId = 1;
        a1.PatientName = "Ravi";

        // Display
        a1.Display();
    }
}
public class Appointment
{
    public int AppointmentId;
    public string PatientName;
    public string DoctorName;
    public DateTime AppointmentDate;

    public Appointment()
    {
        DoctorName = "General Physician";
        AppointmentDate = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine("Appointment Id: " + AppointmentId);
        Console.WriteLine("Patient Name: " + PatientName);
        Console.WriteLine("Doctor Name: " + DoctorName);
        Console.WriteLine("Appointment Date: " + AppointmentDate);
    }
}