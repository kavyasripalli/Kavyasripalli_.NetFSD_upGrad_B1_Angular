using System;
using System.Collections.Generic;
using System.Text;

using System;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    // Constructor
    public Student(int id, string name, int marks)
    {
        StudentId = id;
        Name = name;
        Marks = marks;
    }

    // Virtual Method
    public virtual string CalculateGrade()
    {
        if (Marks > 50)
            return "Pass";
        else
            return "Fail";
    }
}

public class SchoolStudent : Student
{
    public SchoolStudent(int id, string name, int marks)
        : base(id, name, marks)
    {
    }

    public override string CalculateGrade()
    {
        if (Marks > 40)
            return "Pass";
        else
            return "Fail";
    }
}

public class CollegeStudent : Student
{
    public CollegeStudent(int id, string name, int marks)
        : base(id, name, marks)
    {
    }

    public override string CalculateGrade()
    {
        if (Marks > 50)
            return "Pass";
        else
            return "Fail";
    }
}

public class OnlineStudent : Student
{
    public OnlineStudent(int id, string name, int marks)
        : base(id, name, marks)
    {
    }

    public override string CalculateGrade()
    {
        if (Marks > 60)
            return "Pass";
        else
            return "Fail";
    }
}

class task5
{
    static void Main()
    {
        Student[] students = new Student[]
        {
            new SchoolStudent(1, "Ravi", 45),
            new CollegeStudent(2, "Anita", 55),
            new OnlineStudent(3, "Rahul", 58)
        };

        foreach (Student student in students)
        {
            Console.WriteLine(
                "ID: " + student.StudentId +
                " | Name: " + student.Name +
                " | Marks: " + student.Marks +
                " | Result: " + student.CalculateGrade()
            );
        }
    }
}