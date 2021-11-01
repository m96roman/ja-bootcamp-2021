using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class RepositoryUser
    {
        public static UserContext users = new UserContext();

        public static void Create(User user)
        {
            users.Users.Add(user);
        }

        public static void Edit(User user)
        {
            users.Users[users.Users.Find(d => d.Id == user.Id).Id] = user;
        }

        public static void Delete(User user)
        {
            users.Users.Remove(user);
        }

        public static User GetById(int id)
        {
            return users.Users.Find(d => d.Id == id);
        }

        public static IEnumerable<User> GetUsers()
        {
            return users.Users;
        }
    }
}