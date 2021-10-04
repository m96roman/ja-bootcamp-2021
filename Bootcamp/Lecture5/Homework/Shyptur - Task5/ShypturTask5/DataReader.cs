using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    class DataReader
    {
        public DbResult<List<string>> GetCityNames()
        {
            List<string> data = new List<string>();

            data.Add("Lviv");
            data.Add("Uzh");
            data.Add("Kiev");

            DbResult<List<string>> dbResults = new DbResult<List<string>>(true, data);

            return dbResults;
        }

        public DbResult<int> GetMagicNumber()
        {
            Random random = new Random();
            bool[] boolrnd = new bool[] { true, false };
            DbResult<int> dbResult = new DbResult<int>(boolrnd[random.Next(boolrnd.Length)], random.Next());

            return dbResult;
        }
    }
}
