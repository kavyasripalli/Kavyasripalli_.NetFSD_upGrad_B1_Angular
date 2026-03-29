using System;

public class Assignment8
{
    public static void Run()
    {
        PatientRecord.HospitalName = "Apollo Hospital";

        PatientRecord p1 = new PatientRecord(101, "Ravi", 40, "Fever");
        PatientRecord p2 = new PatientRecord(102, "Neha", 35, "Diabetes");
        PatientRecord p3 = new PatientRecord(103, "Rahul", 50, "Heart Disease");

        p1.DisplayPatientRecord();
        Console.WriteLine();

        p2.DisplayPatientRecord();
        Console.WriteLine();

        p3.DisplayPatientRecord();
    }
}

public class PatientRecord
{
    public static string HospitalName;

    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }

    public PatientRecord(int id, string name, int age, string disease)
    {
        PatientId = id;
        PatientName = name;
        Age = age;
        Disease = disease;
    }

    public void DisplayPatientRecord()
    {
        Console.WriteLine("Hospital: " + HospitalName);
        Console.WriteLine("Patient Id: " + PatientId);
        Console.WriteLine("Name: " + PatientName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Disease: " + Disease);
    }
}