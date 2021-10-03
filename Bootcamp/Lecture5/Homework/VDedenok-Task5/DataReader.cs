using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task5
{
    class DataReader
    {
        public DbResult GetCityNames(string city)
        {
            var res1 = new DbResult
            {
                Value = city
            };
           
            Console.WriteLine($"Result is {res1.IsSucceded}, value is {res1.Value}.");
            return res1;
        }

        public DbResult GetMagicNumber()
        {
            var res = new DbResult();

            Random r = new Random();
            int genRand = r.Next(0, 50);

            if (genRand % 3 == 0)
            {
                res.IsSucceded = "failed";
            }
            else
            {
                res.IsSucceded = "successful";
            }
           
            Console.WriteLine($"Result is {res.IsSucceded}, value is {res.Value}.");
            return res;
        }
    }
}
