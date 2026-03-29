using System;
using System.Collections.Generic;

class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Disease { get; set; }
}

class Assignment5
{
    public static void Run()
    {
        Queue<Patient> patients = new Queue<Patient>();

        patients.Enqueue(new Patient { Id = 1, Name = "A", Disease = "Fever" });
        patients.Enqueue(new Patient { Id = 2, Name = "B", Disease = "Cold" });
        patients.Enqueue(new Patient { Id = 3, Name = "C", Disease = "Headache" });
        patients.Enqueue(new Patient { Id = 4, Name = "D", Disease = "Cough" });
        patients.Enqueue(new Patient { Id = 5, Name = "E", Disease = "Flu" });

        Console.WriteLine("Serving 2 patients:");
        for (int i = 0; i < 2; i++)
        {
            if (patients.Count > 0)
            {
                var p = patients.Dequeue();
                Console.WriteLine("Served: " + p.Name);
            }
        }

        Console.WriteLine("\nNext Patient:");
        if (patients.Count > 0)
            Console.WriteLine(patients.Peek().Name);

        Console.WriteLine("\nRemaining Patients:");
        foreach (var p in patients)
            Console.WriteLine($"{p.Name} - {p.Disease}");

        // bonus - VIP queue
        Queue<Patient> vip = new Queue<Patient>();
        vip.Enqueue(new Patient { Id = 100, Name = "VIP1", Disease = "Emergency" });

        Console.WriteLine("\nVIP Patient First:");
        while (vip.Count > 0)
            Console.WriteLine("VIP Served: " + vip.Dequeue().Name);
    }
}