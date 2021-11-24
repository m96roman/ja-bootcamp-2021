using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            VodafoneUserRepository vodafoneUser = new VodafoneUserRepository();
        //   Proxy proxy = new Proxy(vodafoneUser);

         //  proxy.GetUserList().ForEach(l=>Console.WriteLine(l));
           IUserRepository userRepository = new Proxy(vodafoneUser);
           userRepository.GetUserList().ForEach(l => Console.WriteLine(l)); ;
           userRepository.GetUserList().ForEach(l => Console.WriteLine(l)); ;
           userRepository.GetUserList().ForEach(l => Console.WriteLine(l)); ;



        }
    }
}
