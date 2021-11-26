using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Database
    {
        private static Database instance { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public Database getInstance()
        {
            if (instance == null)
            {
                instance = new Database();
                Console.WriteLine("Created 1 instanse");
                return instance;
            }

            return instance;
        }
    }
}
