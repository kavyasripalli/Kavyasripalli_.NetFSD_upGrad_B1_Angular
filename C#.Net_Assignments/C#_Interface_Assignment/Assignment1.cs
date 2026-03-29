using System;

interface GovtRules
{
    double EmployeePF(double basicSalary);
    string LeaveDetails();
    double gratuityAmount(float serviceCompleted, double basicSalary);
}

// tcs
class TCS : GovtRules
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Desg { get; set; }
    public double BasicSalary { get; set; }

    public TCS(int id, string name, string dept, string desg, double salary)
    {
        EmpId = id;
        Name = name;
        Dept = dept;
        Desg = desg;
        BasicSalary = salary;
    }

    public double EmployeePF(double basicSalary)
    {
        double empPF = 0.12 * basicSalary;
        double employerPF = 0.0833 * basicSalary;
        double pension = 0.0367 * basicSalary;
        return empPF + employerPF + pension;
    }

    public string LeaveDetails()
    {
        return "CL:1/month, SL:12/year, PL:10/year";
    }

    public double gratuityAmount(float service, double basicSalary)
    {
        if (service > 20) return 3 * basicSalary;
        else if (service > 10) return 2 * basicSalary;
        else if (service > 5) return basicSalary;
        else return 0;
    }

    public void Display(float service)
    {
        Console.WriteLine("TCS Employee: " + Name);
        Console.WriteLine("PF: " + EmployeePF(BasicSalary));
        Console.WriteLine("Leave: " + LeaveDetails());
        Console.WriteLine("Gratuity: " + gratuityAmount(service, BasicSalary));
    }
}

// accenture
class Accenture : GovtRules
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public string Dept { get; set; }
    public string Desg { get; set; }
    public double BasicSalary { get; set; }

    public Accenture(int id, string name, string dept, string desg, double salary)
    {
        EmpId = id;
        Name = name;
        Dept = dept;
        Desg = desg;
        BasicSalary = salary;
    }

    public double EmployeePF(double basicSalary)
    {
        return 0.12 * basicSalary + 0.12 * basicSalary;
    }

    public string LeaveDetails()
    {
        return "CL:2/month, SL:5/year, PL:5/year";
    }

    public double gratuityAmount(float service, double basicSalary)
    {
        return 0;
    }

    public void Display(float service)
    {
        Console.WriteLine("Accenture Employee: " + Name);
        Console.WriteLine("PF: " + EmployeePF(BasicSalary));
        Console.WriteLine("Leave: " + LeaveDetails());
        Console.WriteLine("Gratuity: " + gratuityAmount(service, BasicSalary));
    }
}

class Assignment1
{
    public static void Run()
    {
        TCS t = new TCS(1, "Kavya Sri", "IT", "Dev", 50000);
        t.Display(6);

        Console.WriteLine("-------------------");

        Accenture a = new Accenture(2, "Kavya", "HR", "Manager", 40000);
        a.Display(4);
    }
}