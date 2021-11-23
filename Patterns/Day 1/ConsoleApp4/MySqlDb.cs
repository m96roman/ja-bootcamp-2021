using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    public class MySqlDb : IMySqlDb
    {
        IMySqlConnection _connection;

        public MySqlDb(IMySqlConnection connection)
        {
            _connection = connection;
        }

        public List<T> ExecuteSql<T>(string sql)
        {
            _connection.Connect();
            Console.WriteLine($"Exec SQL Script: {sql}");
            return new List<T>();
        }
    }
}
