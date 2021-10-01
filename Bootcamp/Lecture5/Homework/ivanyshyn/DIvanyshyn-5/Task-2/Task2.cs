using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvanyshyn_5.Task_2
{
    /// <summary>
    /// You need to calculate how many people leave in each city.
    /// In a loop read home city of each person, at least 10. Expect that cities are not unique.
    /// Use best optimized collection for storing city names.
    /// As an output program should print statistic of population in each city.
    /// Example:
    ///  * Lviv - 8
    ///  * Uzhgorod - 3
    ///  * Kyiv - 17
    /// </summary>
    internal class Task2
    {
        static readonly string[] cities = { "Lviv", "Uzhgorod", "Kyiv" };

        public static void Execute()
        {
            Random random = new Random();

            List<Person> persons = new();

            for (int i = 0; i < 50; i++)
            {
                persons.Add(new Person
                {
                    City = cities[random.Next(cities.Length)],
                    Name = "Original person " + i
                });
            }

            var dict = persons.GroupBy(p => p.City).ToDictionary(pC => pC.Key, pC => pC.Count());

            foreach (var item in dict)
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
        }
    }
}
