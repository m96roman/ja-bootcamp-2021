using System;

namespace Task4
{
    public class MySqlConnection : IMySqlConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connection to MySql DB");
        }
    }
}