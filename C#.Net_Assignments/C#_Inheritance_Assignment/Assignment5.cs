using System;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Student() { }

    public Student(int id, string name, double marks)
    {
        StudentId = id;
        Name = name;
        Marks = marks;
    }

    public virtual string CalculateGrade()
    {
        return Marks > 50 ? "Pass" : "Fail";
    }
}

// school
class SchoolStudent : Student
{
    public SchoolStudent(int id, string name, double marks) : base(id, name, marks) { }

    public override string CalculateGrade()
    {
        return Marks > 40 ? "Pass" : "Fail";
    }
}

// college
class CollegeStudent : Student
{
    public CollegeStudent(int id, string name, double marks) : base(id, name, marks) { }

    public override string CalculateGrade()
    {
        return Marks > 50 ? "Pass" : "Fail";
    }
}

// online
class OnlineStudent : Student
{
    public OnlineStudent(int id, string name, double marks) : base(id, name, marks) { }

    public override string CalculateGrade()
    {
        return Marks > 60 ? "Pass" : "Fail";
    }
}

class Assignment5
{
    public static void Run()
    {
        Student[] students = new Student[]
        {
            new SchoolStudent(1, "A", 45),
            new CollegeStudent(2, "B", 55),
            new OnlineStudent(3, "C", 65)
        };

        foreach (Student s in students)
        {
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Grade: " + s.CalculateGrade());
            Console.WriteLine("-------------------");
        }
    }
}