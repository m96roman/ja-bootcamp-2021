using System.Collections.Generic;

namespace Task4_Proxy
{
    public class VodafoneUserRepository : IUserRepository
    {
        public List<string> GetUserList()
        {
            System.Threading.Thread.Sleep(5000);

            return new List<string> { "John", "Rob", "Monica" };
        }
    }
}
