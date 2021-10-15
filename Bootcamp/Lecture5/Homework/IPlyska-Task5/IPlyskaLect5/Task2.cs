﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Task2
    {
        Dictionary<string, int > countedCities = new Dictionary<string, int>();

        List<string> cities = new List<string>()
        {
            "Lviv",
            "Uzhgorod",
            "Kyiv"
        };
        List<string> names = new List<string>()
        {
                "Max",
                "Alex",
                "Ivan",
                "Yuriy",
                "Olga",
                "Viktoria"
        };
        public void Run()
        {          
            List<Person> people = new List<Person>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                people.Add(new Person(cities[random.Next(0, cities.Count)], names[random.Next(0, names.Count)]));
                i++;
            }
           
            foreach (var item in people)
            {
                if (countedCities.ContainsKey(item.City))
                {
                    countedCities[item.City]++;
                }
                else
                {
                    countedCities.TryAdd(item.City, 1);
                }
            }

            foreach (var item in countedCities)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
