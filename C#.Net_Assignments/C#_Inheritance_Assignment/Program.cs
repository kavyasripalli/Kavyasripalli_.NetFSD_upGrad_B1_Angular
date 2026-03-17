using System;

class Staff
{
    public int StaffId { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public Staff(int id, string name, double salary)
    {
        StaffId = id;
        Name = name;
        BaseSalary = salary;
    }

    // Virtual method
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

class Doctor : Staff
{
    public double ConsultationFee { get; set; }

    public Doctor(int id, string name, double salary, double fee)
        : base(id, name, salary)
    {
        ConsultationFee = fee;
    }

    // Method Overriding
    public override double CalculateSalary()
    {
        return BaseSalary + ConsultationFee;
    }
}

class Nurse : Staff
{
    public double NightShiftAllowance { get; set; }

    public Nurse(int id, string name, double salary, double allowance)
        : base(id, name, salary)
    {
        NightShiftAllowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + NightShiftAllowance;
    }
}

class LabTechnician : Staff
{
    public double EquipmentAllowance { get; set; }

    public LabTechnician(int id, string name, double salary, double allowance)
        : base(id, name, salary)
    {
        EquipmentAllowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + EquipmentAllowance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Staff doctor = new Doctor(1, "Dr. Ravi", 50000, 20000);
        Staff nurse = new Nurse(2, "Anita", 30000, 5000);
        Staff technician = new LabTechnician(3, "Rahul", 25000, 4000);

        Console.WriteLine("Doctor Salary: " + doctor.CalculateSalary());
        Console.WriteLine("Nurse Salary: " + nurse.CalculateSalary());
        Console.WriteLine("Lab Technician Salary: " + technician.CalculateSalary());
    }
}