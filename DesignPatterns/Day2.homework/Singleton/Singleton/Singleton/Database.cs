using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Database
    {
        private static Database _databaseInstance;
    
        private Database(){}

        public static Database GetDatabase()
        {
            if (_databaseInstance == null)
            {
                _databaseInstance = new Database();
            }

            return _databaseInstance;
        }
    }
}
