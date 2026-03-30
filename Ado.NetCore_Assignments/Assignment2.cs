using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ado.Net_Assignments
{
    internal class Assignment2
    {
        string connectionString = "Data Source=LAPTOP-RRH9QFR3\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        // 1. INSERT using Stored Procedure
        public void InsertEmployee()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("InsertEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Name", "Kavya");
            command.Parameters.AddWithValue("@Salary", 50000);
            command.Parameters.AddWithValue("@Department", "IT");

            command.ExecuteNonQuery();

            Console.WriteLine("Employee Inserted");

            connection.Close();
        }

        // 2. FETCH by Department
        public void GetEmployeesByDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE Department = @Dept", connection);

            command.Parameters.AddWithValue("@Dept", "IT");

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["EmpId"]} Name:{reader["Name"]} Salary:{reader["Salary"]} Dept:{reader["Department"]}");
            }

            connection.Close();
        }

        // 3. UPDATE using Stored Procedure
        public void UpdateSalary()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("UpdateEmployeeSalary", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@EmpId", 1);
            command.Parameters.AddWithValue("@Salary", 70000);

            command.ExecuteNonQuery();

            Console.WriteLine("Salary Updated");

            connection.Close();
        }

        // 4. DELETE using Parameterized Query
        public void DeleteEmployee()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Employees WHERE EmpId = @Id", connection);

            command.Parameters.AddWithValue("@Id", 1);

            command.ExecuteNonQuery();

            Console.WriteLine("Employee Deleted");

            connection.Close();
        }
    }
}