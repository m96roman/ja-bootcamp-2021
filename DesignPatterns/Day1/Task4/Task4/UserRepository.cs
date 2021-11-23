using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class UserRepository
    {
        private IDataBase _db;

        public UserRepository(IDataBase db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            return _db.GetModel<User>();
        }
    }
}
