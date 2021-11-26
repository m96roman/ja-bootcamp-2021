using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepoProxy userRepoProxy = new UserRepoProxy(new VodafoneUserRepository());

            userRepoProxy.UsersList().Print();
            userRepoProxy.UsersList().Print();
            userRepoProxy.UsersList().Print();
            userRepoProxy.UsersList().Print();
            userRepoProxy.UsersList().Print();
            userRepoProxy.UsersList().Print();
        }


    }

    static class Extensions
    {
        public static void Print(this List<string> list) => Console.WriteLine(string.Join(',', list));
    }
}
