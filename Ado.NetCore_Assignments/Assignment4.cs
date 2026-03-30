using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ado.Net_Assignments
{
    internal class Assignment4
    {
        string connectionString = "Data Source=LAPTOP-RRH9QFR3\\SQLEXPRESS01;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        public void CreateOrder()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                // Insert into Orders
                SqlCommand orderCmd = new SqlCommand(
                    "INSERT INTO Orders (CustomerName, TotalAmount) OUTPUT INSERTED.OrderId VALUES ('Kavya', 1000)",
                    connection,
                    transaction
                );

                int orderId = (int)orderCmd.ExecuteScalar();

                // Insert multiple OrderItems
                SqlCommand item1 = new SqlCommand(
                    "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@OrderId, @ProductName, @Qty)",
                    connection,
                    transaction
                );

                item1.Parameters.AddWithValue("@OrderId", orderId);
                item1.Parameters.AddWithValue("@ProductName", "Laptop");
                item1.Parameters.AddWithValue("@Qty", 1);
                item1.ExecuteNonQuery();

                SqlCommand item2 = new SqlCommand(
                    "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@OrderId, @ProductName, @Qty)",
                    connection,
                    transaction
                );

                item2.Parameters.AddWithValue("@OrderId", orderId);
                item2.Parameters.AddWithValue("@ProductName", "Mouse");
                item2.Parameters.AddWithValue("@Qty", 2);
                item2.ExecuteNonQuery();

                // If everything is successful
                transaction.Commit();
                Console.WriteLine("Order and Items Inserted Successfully");
            }
            catch (Exception ex)
            {
                // If any error occurs
                transaction.Rollback();
                Console.WriteLine("Transaction Failed: " + ex.Message);
            }

            connection.Close();
        }
    }
}