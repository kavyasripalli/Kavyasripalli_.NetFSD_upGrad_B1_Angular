using System;
class Staff
{
    public int StaffId { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

//Doctor
class Doctor : Staff
{
    public double ConsultationFee { get; set; }

    public override double CalculateSalary()
    {
        return BaseSalary + ConsultationFee;
    }
}

//Nurse
class Nurse : Staff
{
    public double NightShiftAllowance { get; set; }

    public override double CalculateSalary()
    {
        return BaseSalary + NightShiftAllowance;
    }
}

//LabTechnician
class LabTechnician : Staff
{
    public double EquipmentAllowance { get; set; }

    public override double CalculateSalary()
    {
        return BaseSalary + EquipmentAllowance;
    }
}
class Assignment1
{
    public static void Run()
    {
        Staff s1 = new Doctor
        {
            StaffId = 1,
            Name = "Dr. Kiran",
            BaseSalary = 50000,
            ConsultationFee = 20000
        };

        Staff s2 = new Nurse
        {
            StaffId = 2,
            Name = "Kavya",
            BaseSalary = 30000,
            NightShiftAllowance = 5000
        };

        Staff s3 = new LabTechnician
        {
            StaffId = 3,
            Name = "Ramesh",
            BaseSalary = 25000,
            EquipmentAllowance = 3000
        };

        Staff[] staffList = { s1, s2, s3 };

        foreach (Staff staff in staffList)
        {
            Console.WriteLine("Name: " + staff.Name);
            Console.WriteLine("Salary: " + staff.CalculateSalary());
            Console.WriteLine("-------------------");
        }
    }
}