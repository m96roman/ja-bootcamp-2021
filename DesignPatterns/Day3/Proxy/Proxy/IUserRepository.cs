using System.Collections.Generic;

namespace Proxy
{
    internal interface IUserRepository
    {
        List<string> UsersList();
    }
}
