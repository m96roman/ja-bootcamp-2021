using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class VodafoneUserRepository:IUserRepository
    {
        public List<string> GetUserList()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Rael Date");

            return new List<string> {"John", "Rob", "Monica"};
        }
    }
}
