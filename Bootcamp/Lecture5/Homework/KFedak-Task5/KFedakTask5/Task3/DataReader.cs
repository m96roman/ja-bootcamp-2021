using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask5
{
    class DataReader
    {
        public DbResult<List<string>> GetCityNames(Dictionary<string, int> population)
        {
            var city = new List<string>();

            foreach (var element in population)
            {
                city.Add(element.Key);
            }

            var dbResult = new DbResult<List<string>>()
            {
                IsSuccede = true,
                Value = city
            };

            return dbResult;
        }

        public DbResult<int> GetMagicNumber()
        {
            Random r = new Random();
            var i = r.Next(10, 50);
            var dbResult = new DbResult<int>()
            {
                IsSuccede = false,
                Value = i
            };

            return dbResult;
        }
    }
}
