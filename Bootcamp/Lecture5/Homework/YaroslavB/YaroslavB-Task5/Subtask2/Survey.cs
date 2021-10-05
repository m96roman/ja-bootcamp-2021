using System;
using System.Collections.Generic;

namespace YaroslavB_Task5
{
    class Survey
    {
        public Survey()
        {

        }

        public void ShowSurveyResult()
        {
            var users = GetUserList();

            var cities = GetCities();

            Random cityNumber = new Random();

            int rMin = 1;
            int rMax = cities.Count + 1;


            //----- users---------
            Console.WriteLine("Survey participants:");

            int userCount = 1;

            int tempUserCityNum;

            string userCity;

            foreach (string user in users)
            {
                tempUserCityNum = cityNumber.Next(rMin, rMax);

                userCity = GetCityKeyByNumber(cities, tempUserCityNum);

                cities[userCity] += 1;

                Console.WriteLine($"    {userCount}.\t{user} -   \t{userCity}");

                userCount++;
            }

            //----- cities---------
            Console.WriteLine("\nResults:");

            foreach (var city in cities)
            {
                Console.WriteLine($" {city.Key} - {city.Value}");
            }
        }


        #region Private methods

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

        private Dictionary<string, int> GetCities()
        {
            Dictionary<string, int> cities = new Dictionary<string, int>
            {
                {"Berlin", 0},
                {"Kyiv", 0},
                {"London", 0},
                {"Lviv", 0},
            };
            
            return cities;
        }

        private string GetCityKeyByNumber(Dictionary<string, int> dictionary, int position)
        {
            int i = 1;

            foreach(var item in dictionary.Keys)
            {
                if(i == position)
                {
                    return item;
                }

                i++;
            }

            throw new ArgumentOutOfRangeException($"{position} is out of alloved range");
        }

        #endregion

    }

}
