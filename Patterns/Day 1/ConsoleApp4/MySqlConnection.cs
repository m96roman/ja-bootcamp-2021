using System;
using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    public class MySqlConnection : IMySqlConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connection to MySql DB");
        }
    }
}
