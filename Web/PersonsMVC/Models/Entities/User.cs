using System;

namespace PersonsMVC.Models.Entities
{
    public class User
    {
        public User(string id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public string Id { get; private set; }

        public string Name { get; internal set; }

        public string LastName { get; internal set; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}