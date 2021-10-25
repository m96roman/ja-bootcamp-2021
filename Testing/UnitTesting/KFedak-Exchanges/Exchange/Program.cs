using System;
using System.Data;
using System.Data.SqlClient;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Exchange Rates ********************");
            Console.WriteLine("Write amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write currency:");
            string currency = Console.ReadLine();

            Console.WriteLine("Getting Connection ...");

            var datasource = @"DESKTOP-PC\SQLEXPRESS";//your server
            var database = "Students"; //your database name
            var username = "sa"; //username of server to connect
            var password = "password"; //password

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();

        }
    }
}
