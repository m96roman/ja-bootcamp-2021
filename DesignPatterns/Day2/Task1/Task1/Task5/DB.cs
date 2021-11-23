using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public sealed class DB
    {
        private DB()
        {

        }
        private static DB _instance;
        public static DB GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DB();
            }
            return _instance;
        }
        public  void Request(string SQLRequest)
        {
            Console.WriteLine(SQLRequest);
        }
    }
}
