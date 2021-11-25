using System.Collections.Generic;
using ConsoleApp5.Interfaces;
using ConsoleApp5.Models;
using System.Threading;

namespace ConsoleApp5
{
    public class VodafoneUserRepository : IUserRepository
    {
        public List<User> GetUserList()
        {
            Thread.Sleep(5000);

            return new List<User>
            {
                new User{ Name = "John", Age = 20 },
                new User{ Name = "Rob", Age = 21 },
                new User{ Name = "Monica", Age = 22 }
            };
        }
    }
}
