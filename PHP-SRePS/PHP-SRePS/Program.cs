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
            ReadData(sqlite_conn);
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

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();

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
    }
}
