using System;
using System.Collections.Generic;

namespace YaroslavB_Task5
{
    class Survey
    {
        public void ShowSurveyResult()
        {
            var users = GetUserList();
            var cities = GetCities();
            Random cityNumber = new Random();
            int rMin = 0;
            int rMax = cities.Count;
            var peoplePerCity = new Dictionary<string, int>();

            //----- users---------
            Console.WriteLine("Survey participants:");
            int userCount = 1;
            int tempUserCityNum;
            string userCity;

            foreach (string user in users)
            {
                tempUserCityNum = cityNumber.Next(rMin, rMax);
                userCity = cities[tempUserCityNum];
                Console.WriteLine($"    {userCount}.\t{user} -   \t{userCity}");
                
                if(!peoplePerCity.ContainsKey(userCity))
                {
                    peoplePerCity[userCity] = 0;
                }

                peoplePerCity[userCity] += 1;
                userCount++;
            }

            //----- cities---------
            Console.WriteLine("\nResults:");

            foreach (var city in peoplePerCity)
            {
                Console.WriteLine($" {city.Key} - {city.Value}");
            }
        }

        private List<string> GetUserList()
        {
            List<string> users = new List<string>
            {
                "Tom",
                "Jane",
                "John",
                "Amanda",
                "Jack",
                "Mary",
                "Harry",
                "Robert",
                "Michael",
                "Daniel",
                "Barbara",
                "Victoria",
                "Anna",
                "Nicole",
                "Frank",
                "Adam",
                "Henry",
                "David",
                "Betty",
                "Emily"
            };

            return users;
        }

        private List<string> GetCities()
        {
            var cities = new List<string>
            {
                "Berlin",
                "Kyiv",
                "London",
                "Lviv"
            };
            
            return cities;
        }
    }
}
