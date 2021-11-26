using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class UserProxy : IUserRepository 
    {
        private VodafoneUserRepository _vodafone;
        public List<string> users = new List<string>();
        DateTime _caching = DateTime.Now;

        public List<string> GetUserList()
        {
            if (_vodafone == null)
            {
                _vodafone = new VodafoneUserRepository();
            }

            if (_caching.AddSeconds(20) < DateTime.Now)
            {
                users = _vodafone.GetUserList();
                _caching = DateTime.Now;
            }

            if (users.Count == 0)
            {
                users = _vodafone.GetUserList();
            }

            return users;
        }
    }
}
