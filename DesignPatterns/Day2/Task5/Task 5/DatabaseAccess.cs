using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class DatabaseAccess
    {
        private Database _instance;

        public Database Instanse
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database() { Name = "Nestor", LastName = "Pylat", Age = 1 };
                }

                return _instance;
            }
        }
    }
}
