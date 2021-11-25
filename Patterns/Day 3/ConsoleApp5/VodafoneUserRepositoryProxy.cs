using System.Collections.Generic;
using ConsoleApp5.Models;
using ConsoleApp5.Interfaces;
using System.Threading;

namespace ConsoleApp5
{
    public class VodafoneUserRepositoryProxy : IUserRepository
    {
        private IUserRepository _vodafoneUsers;

        public VodafoneUserRepositoryProxy()
        {
            _vodafoneUsers = new VodafoneUserRepository();
        }

        public List<User> GetUserList()
        {
            Thread.Sleep(5000);

            return _vodafoneUsers.GetUserList();
        }
    }
}
