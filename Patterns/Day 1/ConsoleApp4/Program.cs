using System;
using ConsoleApp4.Interfaces;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new MySqlConnection();

            IMySqlDb db = new MySqlDb(connection);

            IUserRepository repo = new UserRepository(db);

            Console.WriteLine($"Users count {repo.GetUsers().Count}");
        }
    }
}
