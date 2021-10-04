using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRoshko_Task5
{
    public class DataReader
    {
        private Random rand = new Random();

        public DbResult<List<string>> GetCityNames()
        {
            return new DbResult<List<string>>
            {
                IsSucceded = true,

                Value = new List<string> {"Lviv","Kiev","Uzghorod"}
            };
        }
        

        public DbResult<int> GetMagicNumber()
        {
            return new DbResult<int>
            {
                IsSucceded = (rand == null)?false: true,

                Value = rand.Next()              
            };
        }
    }
}
