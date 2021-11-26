using System.Collections.Generic;
using ConsoleApp4.Interfaces;
using ConsoleApp4.Models;

namespace ConsoleApp4
{
    public class UserRepository : IUserRepository
    {
        IMySqlDb _db;

        public UserRepository(IMySqlDb db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            return _db.ExecuteSql<User>("select * from user");
        }
    }
}
