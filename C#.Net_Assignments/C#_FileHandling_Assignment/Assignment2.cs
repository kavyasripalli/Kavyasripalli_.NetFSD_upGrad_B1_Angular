using System;
using System.IO;

class Assignment2
{
    public static void Run()
    {
        Console.WriteLine("1. Create Report");
        Console.WriteLine("2. Read Report");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Roll Number: ");
            string roll = Console.ReadLine();

            Console.Write("Marks 1: ");
            int m1 = int.Parse(Console.ReadLine());

            Console.Write("Marks 2: ");
            int m2 = int.Parse(Console.ReadLine());

            Console.Write("Marks 3: ");
            int m3 = int.Parse(Console.ReadLine());

            // validation
            if (m1 < 0 || m2 < 0 || m3 < 0)
            {
                Console.WriteLine("Invalid marks");
                return;
            }

            int total = m1 + m2 + m3;
            double avg = total / 3.0;

            string grade;
            if (avg >= 75) grade = "A";
            else if (avg >= 50) grade = "B";
            else if (avg >= 35) grade = "C";
            else grade = "Fail";

            string content =
$@"Student Name: {name}
Roll Number: {roll}
Marks: {m1}, {m2}, {m3}
Total: {total}
Average: {avg}
Grade: {grade}";

            File.WriteAllText($"{roll}.txt", content);

            Console.WriteLine("Report saved");
        }
        else if (choice == 2)
        {
            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            string file = $"{roll}.txt";

            if (File.Exists(file))
            {
                string data = File.ReadAllText(file);
                Console.WriteLine("\nReport:");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Report not found");
            }
        }
    }
}