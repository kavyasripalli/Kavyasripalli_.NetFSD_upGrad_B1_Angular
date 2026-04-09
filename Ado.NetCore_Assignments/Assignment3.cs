using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ado.Net_Assignments
{
    internal class Assignment3
    {
        string connectionString = "Data Source=DESKTOP-DA9RDQ5\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        SqlDataAdapter adapter;
        DataSet ds;

        // 1. Load Data
        public void LoadData()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            adapter = new SqlDataAdapter("SELECT * FROM Products", connection);

            ds = new DataSet();

            adapter.Fill(ds, "Products");

            Console.WriteLine("Data Loaded into DataSet");
        }

        // 2. Display Data
        public void DisplayProducts()
        {
            DataTable table = ds.Tables["Products"];

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Id:{row["ProductId"]} Name:{row["ProductName"]} Price:{row["Price"]} Stock:{row["Stock"]}");
            }
        }

        // 3. Add Product (Offline)
        public void AddProduct()
        {
            DataTable table = ds.Tables["Products"];

            DataRow newRow = table.NewRow();

            newRow["ProductName"] = "Laptop";
            newRow["Price"] = 60000;
            newRow["Stock"] = 5;

            table.Rows.Add(newRow);

            Console.WriteLine("Product Added (Offline)");
        }

        // 4. Update Product (Offline)
        public void UpdateProduct()
        {
            DataTable table = ds.Tables["Products"];

            if (table.Rows.Count > 0)
            {
                table.Rows[0]["Price"] = 65000;
                Console.WriteLine("Product Updated (Offline)");
            }
        }

        // 5. Delete Product (Offline)
        public void DeleteProduct()
        {
            DataTable table = ds.Tables["Products"];

            if (table.Rows.Count > 0)
            {
                table.Rows[0].Delete();
                Console.WriteLine("Product Deleted (Offline)");
            }
        }

        // 6. Save Changes to Database
        public void SaveChanges()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Update(ds, "Products");

            Console.WriteLine("Changes Saved to Database");
        }
    }
}
