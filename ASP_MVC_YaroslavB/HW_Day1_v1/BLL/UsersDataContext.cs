using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using HW_Day1_v1.Models;
using Newtonsoft.Json;

namespace HW_Day1_v1.BLL
{
    public static class UsersDataContext
    {
        private static string _pathToFile;

        public static List<User> Users { get; private set; }

        static UsersDataContext()
        {
            _pathToFile = Path.Combine(Path.GetTempPath(), "UsersList.json");
        }

        public static void Initialize()
        {
            if(!IsUsersFileExist())
            {
                Serialize(CreateInitUserColection());
            }
        }

        public static void Serialize(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(_pathToFile, json);
        }

        /// <summary>
        /// ! Will return new initial User collection in case of failure reading data from a file
        /// </summary>
        public static List<User> DeSerialize()
        {
            Initialize();
            List<User> users;
            string json = File.ReadAllText(_pathToFile);

            try
            {
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch(Exception)
            {
                users = CreateInitUserColection();
            }         

            return users;
        }

        private static bool IsUsersFileExist()
        {
            return File.Exists(_pathToFile);
        }

        private static List<User> CreateInitUserColection()
        {
            var users = new List<User>
            {
                new User(){Id = 1, FirstName = "Tom", LastName = "Cooper"},
                new User(){Id = 2, FirstName = "John", LastName = "Thomas"},
                new User(){Id = 3, FirstName = "Steve", LastName = "Green "},
                new User(){Id = 4, FirstName = "Bill", LastName = "Johnson "},
                new User(){Id = 5, FirstName = "Ron", LastName = "Clark "},
                new User(){Id = 6, FirstName = "Chris", LastName = "Harris "},
                new User(){Id = 7, FirstName = "Rob", LastName = "Taylor "}
            };

            return users;
        }
    }
}