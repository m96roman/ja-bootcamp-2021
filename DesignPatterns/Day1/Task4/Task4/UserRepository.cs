using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class UserRepository
    {
        private MySqlDb _db;

        public UserRepository(MySqlDb db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            return _db.ExecuteSql<User>("select * from user");
        }
    }
}
