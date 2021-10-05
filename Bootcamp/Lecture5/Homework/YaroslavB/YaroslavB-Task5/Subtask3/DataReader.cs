using System.Collections.Generic;
using System;

namespace YaroslavB_Task5
{
    class DataReader
    {
        public DbResult<List<string>> GetCityNames()
        {
            var cityList = new List<string>
            {
               "Berlin",
               "Kyiv",
               "London",
               "Lviv"
            };

            return new DbResult<List<string>>(cityList, true);
        }
        public DbResult<int> GetMagicNumber()
        {
            var rd = new Random().Next(0, 10);

            return new DbResult<int>(rd, rd < 5);
        }
    }
}
