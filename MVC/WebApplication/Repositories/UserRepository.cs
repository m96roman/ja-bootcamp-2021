using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public static class UserRepository
    {
        private static UserContext users = new UserContext();

        public static IEnumerable<User> GetUsers()
        {
            return users.Users;
        }

        public static IEnumerable<User> GetUsersSearch(string textSearch)
        {
            return users.Users.Where(x => x.FirstName == textSearch || x.LastName == textSearch);
        }

        public static User GetUserById(int id)
        {
            return users.Users.Find(x => x.Id == id);
        }

        public static void InsertUser(User user)
        {
            users.Users.Add(user);
        }

        public static void UpdateUser(User user)
        {
            users.Users[user.Id] = user;
        }

        public static void DeleteUser(User user)
        {
            users.Users.Remove(user);
        }
    }
}