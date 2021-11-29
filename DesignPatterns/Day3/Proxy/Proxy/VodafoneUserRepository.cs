using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proxy
{
    class VodafoneUserRepository : IUserRepository
    {
        public List<string> GetUserList()
        {
            Thread.Sleep(5000);
            return new List<string> { "John", "Rob", "Monica" };
        }
    }
}
