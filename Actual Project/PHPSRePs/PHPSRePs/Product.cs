using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows;
using System.Linq;
using System.Threading.Tasks;

namespace PHP_SRePS
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _cost;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public Product(int id, string name, decimal cost)
        {
            _id = id;
            _name = name;
            _cost = cost;
        }

        public static bool operator <(Product a, Product b)
        {
            bool res = false;
            if(a.ID < b.ID)
            {
                res = true;
            }
            return res;
        }
        public static bool operator >(Product a, Product b)
        {
            bool res = false;
            if (a.ID > b.ID)
            {
                res = true;
            }
            return res;
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
        static void AddSale(SQLiteConnection conn, int productID, int userID, DateTime saleDate, int stock, int saleNumber)
        {

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "INSERT INTO Sales([product_id], [user_id], [datetime], [quantity], [sales_number]) VALUES(@productID, @userID, @saleDate, @stock, @saleNumber);";
            sqlite_cmd.CommandText = msg;//"INSERT INTO tblActivity ([Activity_Category], [Activity_Category_Sub], [Activity_Start], [Activity_End], [Activity_Duration]) VALUES (@ActivityCategory, @ActivityCategorySub, @ActivityStart, @ActivityEnd, @ActivityDuration);";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@productID", productID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@userID", userID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleDate", saleDate));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleNumber", saleNumber));
            sqlite_cmd.ExecuteNonQuery();
        }
        static void EditSale(SQLiteConnection conn, int saleID, int productID, int userID, DateTime saleDate, int stock, int saleNumber)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            string msg = "UPDATE Sales SET product_id = @productID, user_id = @userID, datetime = @saleDate, quantity = @stock, sales_number = @saleNumber WHERE sales_id = @saleID;";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@productID", productID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@userID", userID));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleDate", saleDate));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@stock", stock));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleNumber", saleNumber));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@saleID", saleID));
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
            sqlite_cmd.CommandText = "SELECT * FROM Sales WHERE sales_id = " + ID + ";";

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
                Product saleProduct = GetProduct(conn, (int)productID);
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
