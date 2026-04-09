using System;
using Microsoft.Data.SqlClient;

namespace Ado.Net_Assignments
{
    internal class Assignment1
    {
        string connectionString = "Data Source=DESKTOP-DA9RDQ5\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        // INSERT
        public void InsertStudent()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Students (Name, Age, Grade) VALUES ('Kavya', 22, 'A')", connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Student Inserted Successfully");

            connection.Close();
        }

        // READ
        public void GetStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["Id"]} Name:{reader["Name"]} Age:{reader["Age"]} Grade:{reader["Grade"]}");
            }

            connection.Close();
        }

        // UPDATE
        public void UpdateStudent()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Students SET Grade='A+' WHERE Id=1", connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Student Updated Successfully");

            connection.Close();
        }

        // DELETE
        public void DeleteStudent()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Students WHERE Id=1", connection);

            command.ExecuteNonQuery();

            Console.WriteLine("Student Deleted Successfully");

            connection.Close();
        }
    }
}
