using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new List<Person>
            {
                new Person
                {
                    Name = "Vasyl",
                    City = Cities.Lviv
                },
                new Person
                {
                    Name = "Andriy",
                    City = Cities.Uzhgorod
                },
                new Person
                {
                    Name = "Taras",
                    City = Cities.Lviv
                },
                new Person
                {
                    Name = "Sofiya",
                    City = Cities.Lviv
                },
                new Person
                {
                    Name = "Olena",
                    City = Cities.Lviv
                },
                new Person
                {
                    Name = "Viktoriya",
                    City = Cities.Kyiv
                },
                new Person
                {
                    Name = "Oleh",
                    City = Cities.Lviv
                },
                new Person
                {
                    Name = "Anton",
                    City = Cities.Uzhgorod
                },
                new Person
                {
                    Name = "Mariya",
                    City = Cities.Kyiv
                },
                new Person
                {
                    Name = "Katya",
                    City = Cities.Uzhgorod
                }
            };

            GetPopulationCities(peoples);
        }
        public static void GetPopulationCities<T>(List<T> peoples) where T : Person
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            counter.Add(Cities.Lviv, peoples.Count(item => item.City == Cities.Lviv));
            counter.Add(Cities.Kyiv, peoples.Count(item => item.City == Cities.Kyiv));
            counter.Add(Cities.Uzhgorod, peoples.Count(item => item.City == Cities.Uzhgorod));

            foreach (var item in counter)
            {
                Console.WriteLine($"In city {item.Key} we have {item.Value} citizens");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string City { get; set; }
        }

        public static class Cities
        {
            public const string Lviv = "Lviv";
            public const string Uzhgorod = "Uzhgorod";
            public const string Kyiv = "Kyiv";
        }
    }
}
