using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationApp
{
    /// <summary>
    /// You need to calculate how many people leave in each city. In a loop read home city of each person, 
    /// at least 10. Expect that cities are not unique. Use best optimized collection for storing city names. 
    /// As an output program should print statistic of population in each city. 
    /// Example: 
    /// * Lviv - 8 
    /// * Uzhgorod - 3 
    /// * Kyiv - 17
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, Person>
            {
                { 1, new Person("Valera", Cities.UZHOROD) },
                { 2, new Person("Misha", Cities.UZHOROD) },
                { 3, new Person("John", Cities.LVIV) },
                { 4, new Person("Mike", Cities.LVIV) },
                { 5, new Person("David", Cities.UZHOROD) },
                { 6, new Person("Karl", Cities.KYIV) },
                { 7, new Person("Sveta", Cities.KYIV) },
                { 8, new Person("Karolina", Cities.LVIV) },
                { 9, new Person("Iveta", Cities.LVIV) },
                { 10, new Person("Iva", Cities.KYIV) },
                { 11, new Person("Ben", Cities.UZHOROD) },
                { 12, new Person("Valeriy", Cities.LVIV) },

            };

            var uzhorodPopulatiom = data.Count(u => u.Value.City == Cities.UZHOROD);
            var lvivPopulation = data.Count(u => u.Value.City == Cities.LVIV);
            var kyivPopulatiom = data.Count(u => u.Value.City == Cities.KYIV);

            Console.WriteLine($"In Uzhorod lives {uzhorodPopulatiom}");
            Console.WriteLine($"In Lviv lives {lvivPopulation}");
            Console.WriteLine($"In Kyiv lives {kyivPopulatiom}");
        }
    }
}
