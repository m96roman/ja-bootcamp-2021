using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository repo = new UserRepository(new MySqlDb(new MySqlConnection()));
            Console.WriteLine($"Users count {repo.GetUsers().Count}");
            Console.ReadLine();

            //Dependency Inversion principle - modules in program should depend on abstractions not otherwise, so we are creating -
            // interfaces to not violate this principle
        }
    }
}
