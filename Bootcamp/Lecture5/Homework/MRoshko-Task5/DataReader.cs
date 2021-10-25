using System;
using System.Collections.Generic;

namespace MRoshko_Task5
{
    public class DataReader
    {
        private Random rand = new Random();

        public DbResult<List<string>> GetCityNames()
        {
            return new DbResult<List<string>>
            {
                Value = new List<string> {"Lviv","Kiev","Uzghorod"}
            };
        }

        public DbResult<int> GetMagicNumber()
        {
            return new DbResult<int>
            {
                Value = rand.Next()
            };
        }
    }
}
