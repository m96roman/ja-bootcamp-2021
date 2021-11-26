using System;
using System.Collections.Generic;

namespace Task4_Proxy
{
    class Client
    {
        private IUserRepository _repository;

        public Client(IUserRepository repository)
        {
            _repository = repository;
        }

        public void ProcessUsers()
        {
            List<string> users = _repository.GetUserList();

            Console.WriteLine("Users:");
            users.ForEach(u => Console.WriteLine("  " + u));
            Console.WriteLine("\n\n");
        }
    }
}
