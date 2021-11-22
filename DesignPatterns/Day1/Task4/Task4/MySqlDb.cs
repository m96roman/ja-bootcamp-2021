using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MySqlDb<T>: ApplicationContext<T>
    {
        ISQLConnection _connection;

        public MySqlDb(MySqlConnection connection)
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
