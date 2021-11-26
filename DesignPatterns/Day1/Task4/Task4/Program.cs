using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository repo = new UserRepository(new MySqlDb(new MySqlConnection()));
            Console.WriteLine($"Users count {repo.GetUsers().Count}");
            Console.ReadLine();
        }
    }
}
