using System.Collections.Generic;

namespace WebApplication.Models
{
    public class UserContext
    {
        public List<User> Users { get; set; }

        public UserContext()
        {
            Users = new List<User>();
        }
    }
}