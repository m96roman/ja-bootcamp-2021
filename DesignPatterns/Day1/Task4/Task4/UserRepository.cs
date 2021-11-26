using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dependency inversion principle

namespace Task4
{
    public class UserRepository
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
