using System.Collections.Generic;
using ConsoleApp5.Models;

namespace ConsoleApp5.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUserList();
    }
}
