using ConsoleApp4.Models;
using System.Collections.Generic;

namespace ConsoleApp4.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
