using IPlyskaMVCPart1.Interfaces;
using IPlyskaMVCPart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.BLL
{
    public class UsersProvider : IUsersProvider
    {
        List<Users> users = new List<Users>()
        {
           new Users(){Id = 0, FirstName = "Tom", LastName = "Fox"},
           new Users(){Id = 1, FirstName = "Mike", LastName = "DrinkWater"},
           new Users(){Id = 2, FirstName = "Dunkan", LastName = "Rice"},
           new Users(){Id = 3, FirstName = "Nick", LastName = "Smith"},
           new Users(){Id = 4, FirstName = "Aron", LastName = "Hana"}
        };
        private static object _locker = new object();
        public UsersProvider()
        {
           
        }
        public bool AddUser(Users user)
        {
           lock (_locker)
           {
                var getUser = users.FirstOrDefault(x => x.Id == user.Id);
                if (getUser is not null)
                {
                    return false;
                }

                users.Add(user);
           }

            return true;
        }

        public bool EditUser(Users user)
        {
            lock (_locker)
            {
                var userEdited = users.FirstOrDefault(x => x.Id == user.Id);
                if (userEdited is null)
                {
                    return false;
                }
                else
                {
                    userEdited.FirstName = user.FirstName;
                    userEdited.LastName = user.LastName;
                    return true;
                }
            }
        }

        public List<Users> GetAllUsers()
        {
           return users;
        }

        public bool RemoveUser(Users user)
        {
           lock (_locker)
           {
                var userEdited = users.FirstOrDefault(x => x.Id == user.Id);
                if (userEdited is null)
                {
                    return false;
                }
                else
                {
                    users.Remove(userEdited);
                    return true;
                }
           }
        }
    }
}
