using System;
using System.Threading;

namespace Task4_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyRepository proxyRepository = new ProxyRepository(new VodafoneUserRepository());
            Client client = new Client(proxyRepository);

            //simulate serie of requests from client code
            for (int i = 0, delay = 23; i < 5; i++, delay =+ 23)
            {
                client.ProcessUsers();
                Thread.Sleep(delay * 1000);
            }

            Console.WriteLine("\n\nPress \'Enter\' to exit...");
            Console.ReadLine();
        }
    }
}
