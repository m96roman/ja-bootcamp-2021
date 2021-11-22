using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class UserRepository : IRepository<User>
    {
        private readonly IDbContext<User> _db;

        public UserRepository(IDbContext<User> db)
        {
            _db = db;
        }

        public List<User> GetEntities()
        {
            return _db.ExecuteSql("select * from user");
        }
    }
}
