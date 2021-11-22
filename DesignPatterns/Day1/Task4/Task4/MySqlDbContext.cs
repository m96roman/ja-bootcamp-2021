using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //If we want to be free from static type problems
    //The generics is fixing the problem
    public class MySqlContext<T> : IDbContext<T>
    {
        readonly ISqlConnection _connection;

        public MySqlContext(MySqlConnection connection)
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
