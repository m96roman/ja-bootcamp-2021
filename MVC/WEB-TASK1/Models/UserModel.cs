using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_TASK1.Models
{
    public class UserModel        
    {
        private static int Iterator { get; set; } = default;

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public UserModel() : base()
        {
            UserId = Iterator;

            Iterator++;
        }

    }
}
