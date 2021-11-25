using System;

namespace Task5_Singleton
{
    class DataBase
    {
        private static DataBase _instance;
        public static DataBase GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DataBase();
            }

            return _instance;
        }

        private DataBase() { }

        public void SqlQuery(string query)
        {
            Console.WriteLine($"Query: \'{query}\'");
        }
    }
}
