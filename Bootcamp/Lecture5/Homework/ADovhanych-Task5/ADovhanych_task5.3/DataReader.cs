using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_task5._3
{
    class DataReader
    {
        public DbResult<string> GetCityNames()
        {
            return new DbResult<string> { Value = "Kyiv, Uzhgorod", IsSucceded = true };
        }

        public DbResult<int> GetMagicNumber()
        {
            int number = new Random().Next(20);

            return new DbResult<int> { Value = number % 2 == 0 ? number : -1, IsSucceded = number % 2 == 0 };
        }
    }
}
