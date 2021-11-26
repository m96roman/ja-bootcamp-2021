using System;
using System.Threading;

namespace Database_Singelton
{
    public sealed class DatabaseContext
    {
        private static DatabaseContext instance;

        private DatabaseContext()
        {
            Console.WriteLine("Connecting to database..");
            Thread.Sleep(2000);
        }

        private static readonly object _lock = new object();

        public static DatabaseContext GetIntance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseContext();
                    }
                }
            }

            return instance;
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine("Executing..");
            Thread.Sleep(1000);
            Console.WriteLine($"Query {query} was executed");
        }
    }
}
