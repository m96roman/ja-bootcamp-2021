using System.Collections.Generic;
using System.Threading;

namespace Proxy
{
    public class VodafoneUserRepository : IUserRepository
    {
        public List<string> UsersList()
        {
            Thread.Sleep(5000);
            return new List<string> { "John", "Rob", "Monica" };
        }
    }
}
