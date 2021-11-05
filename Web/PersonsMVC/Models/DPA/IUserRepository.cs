using PersonsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonsMVC.Models.DPA
{
    public interface IUserRepository : IDisposable
    {
        void Add(User user);

        bool Delete(string id);

        bool Edit(User user);

        IEnumerable<User> GetUsers();

        IEnumerable<User> GetUsers(Predicate<User> userFilterPredicate);

        User GetUser(string id);
        IEnumerable<User> GetUsers(FilterUserViewModel filter);
    }
}