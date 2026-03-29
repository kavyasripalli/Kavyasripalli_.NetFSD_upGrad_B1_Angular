using System;
namespace C__LINQ_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Student Filtering");
            Console.WriteLine("2. Numbers Collection");
            Console.WriteLine("3. String Operations");
            Console.WriteLine("4. Employee Management");
            Console.WriteLine("5. Orders & Customers");
            Console.WriteLine("6. Duplicate Handling");
            Console.WriteLine("7. Product Inventory");
            Console.WriteLine("8. Multi-Level Grouping");
            Console.WriteLine("9. E-Commerce Scenario");
            Console.WriteLine("10. Custom Sorting");
            Console.WriteLine("11. Employee Dashboard");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Assignment1.Run();
                    break;

                case 2:
                    Assignment2.Run();
                    break;

                case 3:
                    Assignment3.Run();
                    break;

                case 4:
                    Assignment4.Run();
                    break;

                case 5:
                    Assignment5.Run();
                    break;

                case 6:
                    Assignment6.Run();
                    break;

                case 7:
                    Assignment7.Run();
                    break;

                case 8:
                    Assignment8.Run();
                    break;

                case 9:
                    Assignment9.Run();
                    break;

                case 10:
                    Assignment10.Run();
                    break;

                case 11:
                    Assignment11.Run();
                    break;
            }
        }
    }
}
