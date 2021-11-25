using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IUserRepository
    {
        List<string> GetUserList();
    }
}
