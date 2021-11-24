using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface IUserRepository
    {
        List<string> GetUserList();
    }
}
