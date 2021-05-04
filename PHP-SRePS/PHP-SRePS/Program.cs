using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace PHP_SRePS
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Product test = new Product(1, "Test", 5);
//            Product test2 = new Product(2, "Test2", 10);
//            Product test3 = new Product(3, "Test3", 1);
//            Product test4 = new Product(4, "Test4", 7);
//            List<Product> Products = new List<Product>();
//            List<int> Quantities = new List<int>();
//            Products.Add(test);
//            Products.Add(test2);
//            Products.Add(test3);
//            Products.Add(test4);
//            Quantities.Add(4);
//            Quantities.Add(6);
//            Quantities.Add(22);
//            Quantities.Add(8);
//            Sale testSale = new Sale(1738, 324, Products, Quantities, DateTime.Today);
//            List<Sale> testSalesList = new List<Sale>();
//            testSalesList.Add(testSale);
//            SalesReport testSalesReport = new SalesReport(420, testSalesList, DateTime.Today);
//            SalesReport readInReport = new SalesReport();
//            testSalesReport.writeCSV("test");
//        }
//    }
//}


namespace PHP_SRePS
{
    class Program
    {

        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            DataTable t = sqlite_conn.GetSchema("Tables");
            ReadData(sqlite_conn);
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=PHP.db; Version = 3; New = True; Compress = True; ");
            Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
            string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM sales";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
