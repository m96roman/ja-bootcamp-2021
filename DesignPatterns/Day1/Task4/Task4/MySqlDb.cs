using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class MySqlDb<T>: ApplicationContext<T>
    {
        ISQLConnection _connection;

        public MySqlDb(ISQLConnection connection)
        {
            _connection = connection;
        }

        public List<T> ExecuteSql(string sql)
        {
            _connection.Connect();
            Console.WriteLine($"Exec SQL Script: {sql}");
            return new List<T>();
        }
    }
}
