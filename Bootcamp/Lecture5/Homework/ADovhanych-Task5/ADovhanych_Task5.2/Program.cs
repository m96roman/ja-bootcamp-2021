using System;
using System.Collections.Generic;

namespace ADovhanych_Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person { Name = "Nick", City = "Uzhgorod" },
                new Person { Name = "Ben", City = "Lviv" },
                new Person { Name = "Jack", City = "Kyiv" },
                new Person { Name = "Don", City = "Kyiv" },
                new Person { Name = "John", City = "Lviv" },
                new Person { Name = "James", City = "Uzhgorod" },
                new Person { Name = "McDennis", City = "Uzhgorod" },
                new Person { Name = "Peter", City = "Lviv" },
                new Person { Name = "Rob", City = "Lviv" },
                new Person { Name = "Bob", City = "Uzhgorod" }

            };

            var result = new Dictionary<string, int>();

            foreach (Person person in people)
            {
                if (result.ContainsKey(person.City))
                {
                    result[person.City]++;
                }
                else
                {
                    result.Add(person.City, 1);
                }

            }

            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
