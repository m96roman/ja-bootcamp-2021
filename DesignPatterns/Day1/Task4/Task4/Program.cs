using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependency Inversion Principle (DIP)

            IUserRepository repo = new UserRepository(new MySqlDb(new MySqlConnection()));
            Console.WriteLine($"Users count {repo.GetUsers().Count}");
            Console.ReadLine();
        }
    }
}
