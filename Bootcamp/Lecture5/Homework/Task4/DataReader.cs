using System;
using System.Collections.Generic;

namespace Task4
{
    public class DataReader
    {
        public static DbResult<List<string>> GetCityName()
        {
            var Cities = new List<string> { "Lviv", "Kyiv", "Uzhgotrod" };

            return new DbResult<List<string>>(true, Cities);
        }
        public static DbResult<int> GetMagicNumber()
        {
            Random random = new Random();
            int value = random.Next(0, 2);

            return value != 0 ? new DbResult<int>(false, -1) : new DbResult<int>(true, random.Next());
        }
    }
}
