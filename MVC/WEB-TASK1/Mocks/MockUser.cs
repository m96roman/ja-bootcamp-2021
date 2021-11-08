using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_TASK1.Models;

namespace WEB_TASK1.Mocks
{
    public class MockUser
    {
        public IEnumerable<UserModel> AllUsers
        {
            get
            {
                return new List<UserModel>
                {
                    new UserModel{UserName = "Jhon", UserSurname = "Doe" },
                     new UserModel{UserName = "Martin", UserSurname = "Roshko" },
                };
            }
        }
    }
}
