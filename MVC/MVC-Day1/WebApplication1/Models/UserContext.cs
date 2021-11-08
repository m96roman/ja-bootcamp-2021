using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
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