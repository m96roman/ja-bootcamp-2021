using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class DataReader
    {
        public DbResult<List<string>> GetCityNames()
        {
            List<string> citiesName = new List<string>()
            {
                "Lviv",
                "Uzhgorod",
                "Kiiv"
            };

            return new DbResult<List<string>>(true, citiesName);
        }

        public DbResult<int> GetMagicNumber()
        {
            Random random = new Random();
            int x = random.Next(0, 3);

            if (x == 0)
            {
                return new DbResult<int>(false, -1);
            }

            return new DbResult<int>(true, x);
        }
    }
}
