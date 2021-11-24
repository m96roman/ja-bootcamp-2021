using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy:IUserRepository
    {
        private IUserRepository userRepository;
        private List<string> cacheDate= new List<string>();
        private  DateTime cacheOn;

        public Proxy(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            cacheOn=DateTime.MinValue;
        }

        public List<string> GetUserList()
        {
            if (userRepository == null)
                userRepository = new VodafoneUserRepository();
            if (cacheOn.AddMinutes(1)<DateTime.Now)
            {
                cacheDate = userRepository.GetUserList();
                cacheOn = DateTime.Now;
                return cacheDate;
            }

            Console.WriteLine("Proxy");
            return cacheDate;
        }
    }
}
