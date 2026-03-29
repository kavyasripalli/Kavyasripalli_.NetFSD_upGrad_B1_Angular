using System;
using System.IO;
using System.Collections.Generic;

class Assignment1
{
    static string filePath = "employee_log.txt";

    public static void Run()
    {
        Console.WriteLine("1. Add Login");
        Console.WriteLine("2. Update Logout");

        int choice = int.Parse(Console.ReadLine());

        try
        {
            if (choice == 1)
            {
                Console.Write("Employee Id: ");
                string id = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                string loginTime = DateTime.Now.ToString();
                string logoutTime = "NA";

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id}|{name}|{loginTime}|{logoutTime}");
                }

                Console.WriteLine("Login recorded");
            }
            else if (choice == 2)
            {
                Console.Write("Enter Employee Id: ");
                string id = Console.ReadLine();

                List<string> lines = new List<string>();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');

                        if (data[0] == id && data[3] == "NA")
                        {
                            data[3] = DateTime.Now.ToString();
                            line = string.Join("|", data);
                        }

                        lines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Logout updated");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}