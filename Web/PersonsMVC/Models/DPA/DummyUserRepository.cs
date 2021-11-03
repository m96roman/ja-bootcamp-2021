﻿using PersonsMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsMVC.Models.DPA
{
    public class DummyUserRepository : IUserRepository
    {
        public DummyUserRepository()
        {
            Users = new()
            { new("1", "1", "1"), new("12", "12", "12"), new("123", "123", "123"), new("1234", "1234", "1234") };
        }

        public List<User> Users { get; set; }

        public void Add(User user) => Users.Add(user);

        public bool Delete(string id) => Users.RemoveAll(u => u.Id == id) != 0;

        public void Dispose()
        {
            Users = null;
        }

        public bool Edit(User user)
        {
            if (Users.Count != 0 && Users.Contains(user))
            {
                User entity = Users.Find(u => u.Id == user.Id);

                if (entity != null)
                {
                    entity.LastName = user.LastName;
                    entity.Name = user.Name;

                    return true;
                }

            }

            return false;
        }

        public User GetUser(string id) => Users.Find(u => u.Id == id);

        public IEnumerable<User> GetUsers() => Users;

        public IEnumerable<User> GetUsers(Predicate<User> userFilterPredicate) => Users.Where(u => userFilterPredicate.Invoke(u)).ToList();

        public IEnumerable<User> GetUsers(FilterUserViewModel filter)
        {
            return Users.Where(u => filter.IsValid(u)).ToList();
        }
    }
}