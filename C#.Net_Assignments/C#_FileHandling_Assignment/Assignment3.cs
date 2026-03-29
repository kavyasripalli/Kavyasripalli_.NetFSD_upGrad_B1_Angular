using System;
using System.IO;

class Assignment3
{
    public static void Run()
    {
        Console.WriteLine("1. Create File");
        Console.WriteLine("2. Write File");
        Console.WriteLine("3. Read File");
        Console.WriteLine("4. Append File");
        Console.WriteLine("5. Delete File");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter file name: ");
        string file = Console.ReadLine() + ".txt";

        try
        {
            if (choice == 1)
            {
                FileStream fs = new FileStream(file, FileMode.Create);
                fs.Close();
                Console.WriteLine("File created");
            }

            else if (choice == 2)
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    Console.WriteLine("Enter lines (type 'end' to stop):");
                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToLower() == "end") break;
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Written to file");
            }

            else if (choice == 3)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string data = sr.ReadToEnd();
                    Console.WriteLine("\nContent:\n" + data);
                }
            }

            else if (choice == 4)
            {
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    Console.WriteLine("Enter text to append (type 'end'):");
                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToLower() == "end") break;
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Appended");
            }

            else if (choice == 5)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                    Console.WriteLine("File deleted");
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}