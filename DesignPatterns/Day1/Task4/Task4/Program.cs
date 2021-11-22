using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<User> repo = new UserRepository(new MySqlDb<User>(new MySqlConnection()));
            Console.WriteLine($"Users count {repo.getList().Count}");
            Console.ReadLine();
        }
    }
}
