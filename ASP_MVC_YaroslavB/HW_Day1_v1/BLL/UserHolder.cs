using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW_Day1_v1.Models;

namespace HW_Day1_v1.BLL
{
    /// <summary>
    /// Provide user collection
    /// </summary>
    public class UserHolder : IEnumerable<User>
    {
        private static List<User> _users;

        private static UserHolder instance;

        private UserHolder()
        {
            _users = UsersDataContext.DeSerialize();
        }

        public static UserHolder GetInstance()
        {
            if(instance == null)
            {
                instance = new UserHolder();
            }

            return instance;
        }

        public void Add(User user)
        {
            int newId = _users.LastOrDefault().Id + 1;
            _users.Add(new User
            { 
                Id = newId,
                FirstName = user.FirstName,
                LastName = user.LastName
            });
            UsersDataContext.Serialize(_users);
        }

        public void Delete(int userId)
        {
            User userToRemove = _users.FirstOrDefault(u => u.Id == userId);
            _users.Remove(userToRemove);
            UsersDataContext.Serialize(_users);
        }

        public void Edit(User editedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == editedUser.Id);
            user.FirstName = editedUser.FirstName;
            user.LastName = editedUser.LastName;
            UsersDataContext.Serialize(_users);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _users.GetEnumerator();
        }
    }
}