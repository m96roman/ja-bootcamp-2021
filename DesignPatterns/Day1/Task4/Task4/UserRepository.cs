using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class UserRepository:IRepository<User>
    {
        private ApplicationContext<User> _db;

        public UserRepository(ApplicationContext<User> db)
        {
            _db = db;
        }

        public List<User> getList()
        {
            return _db.ExecuteSql("select * from user");
        }

    }
}
