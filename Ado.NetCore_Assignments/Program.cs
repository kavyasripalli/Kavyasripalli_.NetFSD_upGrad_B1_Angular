using System;

namespace Ado.Net_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            Assignment1 a1 = new Assignment1();
            a1.InsertStudent();
            a1.GetStudents();

            Console.WriteLine("---------------------");

            // Assignment 2
            Assignment2 a2 = new Assignment2();
            a2.InsertEmployee();
            a2.GetEmployeesByDepartment();

            Console.WriteLine("---------------------");

            // Assignment 3
            Assignment3 a3 = new Assignment3();
            a3.LoadData();
            a3.DisplayProducts();
            a3.SaveChanges();

            Console.WriteLine("---------------------");

            // Assignment 4
            Assignment4 a4 = new Assignment4();
            a4.CreateOrder();

            Console.WriteLine("---------------------");

            // Assignment 5 (Mini Project)
            Assignment5 a5 = new Assignment5();
            a5.AddBook();
            a5.ViewBooks();
            a5.UpdateBook();
            a5.SearchBook();
            a5.DeleteBook();

            Console.ReadLine();
        }
    }
}