using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MySqlDb : IDataBase
    {
        MySqlConnection _connection;

        public MySqlDb(MySqlConnection connection)
        {
            _connection = connection;
        }


        public List<T> GetModel<T>()
        {
            //here is some code to get sql query (or using some ORM)
            //...

            string sqlQuery = $"select * from user";

            return ExecuteSql<T>(sqlQuery);
        }

        private List<T> ExecuteSql<T>(string sql)
        {
            _connection.Connect();
            Console.WriteLine($"Exec SQL Script: {sql}");
            return new List<T>();
        }
    }
}
