using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepository = new UserProxy();
            VodafoneUserRepository vodafone = new VodafoneUserRepository();

            List<string> proxyUsers = userRepository.GetUserList();

            foreach (var item in proxyUsers)
            {
                Console.WriteLine($"{item}");
            }

            proxyUsers = userRepository.GetUserList();

            foreach (var item in proxyUsers)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
