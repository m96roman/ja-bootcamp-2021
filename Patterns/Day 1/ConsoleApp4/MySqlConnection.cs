using System;
using System.Collections.Generic;
using System.Text;
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
