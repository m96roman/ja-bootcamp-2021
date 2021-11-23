using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
