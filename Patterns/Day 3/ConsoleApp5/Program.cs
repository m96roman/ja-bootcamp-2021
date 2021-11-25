using ConsoleApp5.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Proxy */

            VodafoneUserRepositoryProxy proxy = new VodafoneUserRepositoryProxy();
            List<User> vodafoneUsers = proxy.GetUserList();

            Console.WriteLine("Vodafone Users:");
            foreach(var user in vodafoneUsers)
            {
                Console.WriteLine($"Name: {user.Name} - Age: {user.Age}");
            }
        }
    }
}
