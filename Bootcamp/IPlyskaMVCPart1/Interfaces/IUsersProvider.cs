using IPlyskaMVCPart1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPlyskaMVCPart1.Interfaces
{
    public interface IUsersProvider
    {
       // public List<Users> users { get; set; }
        public bool AddUser(Users user);
        public List<Users> GetAllUsers();
        public bool RemoveUser(Users user);
        public bool EditUser(Users user);
    }
}
