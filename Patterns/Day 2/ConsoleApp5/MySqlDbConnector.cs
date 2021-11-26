using System;

namespace ConsoleApp5
{
    public sealed class MySqlDbConnector
    {
        private static MySqlDbConnector _instance;

        public MySqlDbConnector() { }

        public static MySqlDbConnector GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySqlDbConnector();
            }
            return _instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to data base...");
        }
    }
}
