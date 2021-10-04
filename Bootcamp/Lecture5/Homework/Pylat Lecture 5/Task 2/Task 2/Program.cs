using System;
using System.Collections.Generic;

namespace Task_5_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IStatisticIfCity>() { new Lviv("Lviv", 8), new Lviv("Uzhhorod", 3), new Kyiv("Kyiv", 15) };
            PrintStatistic<IStatisticIfCity>(list);
        }

        public static void PrintStatistic<T>(IEnumerable<T> collection) where T : IStatisticIfCity
        {
            foreach (var item in collection)
            {
                item.IStatisticIfCity();
            }
        }
    }
}