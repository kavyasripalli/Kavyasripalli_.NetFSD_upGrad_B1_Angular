using System;
using Microsoft.Data.SqlClient;

namespace Ado.Net_Assignments
{
    internal class Assignment5
    {
        string connectionString = "Data Source=LAPTOP-RRH9QFR3\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        // 1. Add Book
        public void AddBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)", connection);

            command.Parameters.AddWithValue("@Title", "C# Basics");
            command.Parameters.AddWithValue("@Author", "Kavya");
            command.Parameters.AddWithValue("@Price", 500);

            command.ExecuteNonQuery();

            Console.WriteLine("Book Added Successfully");

            connection.Close();
        }

        // 2. View Books
        public void ViewBooks()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id:{reader["BookId"]} Title:{reader["Title"]} Author:{reader["Author"]} Price:{reader["Price"]}");
            }

            connection.Close();
        }

        // 3. Update Book
        public void UpdateBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Books SET Price=@Price WHERE BookId=@Id", connection);

            command.Parameters.AddWithValue("@Price", 600);
            command.Parameters.AddWithValue("@Id", 1);

            command.ExecuteNonQuery();

            Console.WriteLine("Book Updated");

            connection.Close();
        }

        // 4. Delete Book
        public void DeleteBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Books WHERE BookId=@Id", connection);

            command.Parameters.AddWithValue("@Id", 1);

            command.ExecuteNonQuery();

            Console.WriteLine("Book Deleted");

            connection.Close();
        }

        // 5. Search Book by Name
        public void SearchBook()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Title LIKE @Title", connection);

            command.Parameters.AddWithValue("@Title", "%C#%");

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Found -> Id:{reader["BookId"]} Title:{reader["Title"]} Author:{reader["Author"]} Price:{reader["Price"]}");
            }

            connection.Close();
        }
    }
}