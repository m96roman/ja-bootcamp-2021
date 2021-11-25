using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class UserRepository : IUserRepository
    {
        private IMySqlDb _db;

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
