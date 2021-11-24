using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlDb myDb = MySqlDb.GetInstance();

            myDb.CallMySql();
        }
    }
}
