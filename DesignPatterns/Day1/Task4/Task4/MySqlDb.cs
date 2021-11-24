using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MySqlDb : IMySqlDb
    {
        private MySqlConnection _connection { get; set; }

        public MySqlDb(MySqlConnection connection)
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
