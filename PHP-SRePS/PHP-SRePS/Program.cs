using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    class Program
    {

        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //AddSale(sqlite_conn, 1, 1, 2, DateTime.Now);
            EditSale(sqlite_conn, 15, 2, 2, 7, DateTime.Now.AddDays(1));
            DisplaySale(sqlite_conn, 15);
            DeleteSale(sqlite_conn, 15);
            sqlite_conn.Close();
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(@"Data Source=G:\Documents\Managing IT Project\Repo\PHP-SRePS\PHP-SRePS\PHP.db");
           // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Product";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string msg = "";
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    var myreader = sqlite_datareader.GetValue(i);
                    if (i == (sqlite_datareader.FieldCount - 1))
                    {
                        msg += " " + myreader.ToString();
                    } 
                    else if (i == 0)
                    {
                        msg += myreader.ToString() + ",";
                    }
                    else
                    {
                        msg += " " + myreader.ToString() + ",";
                    }
                   
                }
                Console.WriteLine(msg);
            }
            conn.Close();
        }
        static void AddSale(SQLiteConnection conn, int userID, int productID, int stock, DateTime saleDate)
        {

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "INSERT INTO Sales(product_id, user_id, datetime, quantity) VALUES(" + productID.ToString() + "," + userID.ToString() + "," +  saleDate.ToShortDateString() + "," + stock.ToString() + "); ";
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void EditSale(SQLiteConnection conn, int ID, int userID, int productID, int stock, DateTime saleDate)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "UPDATE Sales SET product_id = " + productID + ", user_id = " + userID + ", datetime = " + saleDate.ToShortDateString() + ", quantity = " + stock + " WHERE sales_id = " + ID + ";";
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void DeleteSale(SQLiteConnection conn, int ID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "DELETE FROM Sales WHERE sales_id = " + ID + ";";
            sqlite_cmd.CommandText = msg;
            sqlite_cmd.ExecuteNonQuery();
        }
        static void DisplaySale(SQLiteConnection conn, int ID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Sales WHERE sales_id = " + ID +";";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string msg = "";
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    var myreader = sqlite_datareader.GetValue(i);
                    if (i == (sqlite_datareader.FieldCount - 1))
                    {
                        msg += " " + myreader.ToString();
                    }
                    else if (i == 0)
                    {
                        msg += myreader.ToString() + ",";
                    }
                    else
                    {
                        msg += " " + myreader.ToString() + ",";
                    }

                }
                Console.WriteLine(msg);
            }
        }
        static Sale GetSale(SQLiteConnection conn, int ID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Sales WHERE sales_id = " + ID + ";";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                var productID = sqlite_datareader.GetValue(1);
                var userID = sqlite_datareader.GetValue(2);
                var dateTime = sqlite_datareader.GetValue(3);
                var stock = sqlite_datareader.GetValue(4);
                Product saleProduct = GetProduct(conn,(int)productID);
                Sale fetchedSale = new Sale(ID, (int)userID, saleProduct, (int)stock, (DateTime)dateTime);
                return fetchedSale;
            }
            return null;
        }
        static Product GetProduct(SQLiteConnection conn, int ID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Product WHERE product_id = " + ID + ";";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                var productName = sqlite_datareader.GetValue(1);
                var price = sqlite_datareader.GetValue(2);
                Product fetchedProduct = new Product(ID, (string)productName, (int)price);
                return fetchedProduct;
            }
            return null;
        }
    }
}
