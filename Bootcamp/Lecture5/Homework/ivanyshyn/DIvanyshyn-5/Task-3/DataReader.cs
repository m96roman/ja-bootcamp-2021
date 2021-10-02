using System;

namespace DIvanyshyn_5.Task_3
{
    class DataReader
    {
        /// <summary>
        /// Gets city names
        /// </summary>
        /// <returns><see cref="DbResult{String[]}"/> with cities</returns>
        public static DbResult<string[]> GetCityNames()
        {
            string[] vs = new[] { "Name1", "Name2", "Name3" };

            return new DbResult<string[]>(true, vs);
        }

        /// <summary>
        /// Return random positive integer
        /// if method fails result value is -1
        /// </summary>
        /// <returns><see cref="DbResult{int}">Result</see> with value</returns>
        public static DbResult<int> GetMagicNumber()
        {
            Random random = new Random();
            int val = random.Next(0, 2);

            if (val != 0)
            {
                return new DbResult<int>(false, -1);
            }

            return new DbResult<int>(true, random.Next());
        }
    }
}
