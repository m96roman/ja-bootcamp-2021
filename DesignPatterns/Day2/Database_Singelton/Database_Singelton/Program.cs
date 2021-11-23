using System;
using System.Threading;

namespace Database_Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => TestDatabase("select * from a; drop table a"));
            Thread thread2 = new Thread(() => TestDatabase("select * from b; drop table b"));
            Thread thread3 = new Thread(() => TestDatabase("select * from a; drop table a"));
            Thread thread4 = new Thread(() => TestDatabase("select * from b; drop table b"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
        }
        public static void TestDatabase(string query)
        {
            DatabaseContext databaseContext = DatabaseContext.GetIntance();
            databaseContext.ExecuteQuery(query);
        }
    }
}
