using System;

namespace Task5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sending SQL query...");

            DataBase db = DataBase.GetInstance();
            db.SqlQuery("select * from users");

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
