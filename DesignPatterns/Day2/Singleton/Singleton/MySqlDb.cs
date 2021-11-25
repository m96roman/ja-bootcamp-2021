using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class MySqlDb
    {
        private static MySqlDb Instance { get; set; }

        private MySqlDb()
        {

        }

        public static MySqlDb GetInstance()
        {
            if (Instance == null)
            {
                Instance = new MySqlDb();
            }

            return Instance;
        }

        public void CallMySql(){
            Console.WriteLine("MySql Call");
        }
    }
}
