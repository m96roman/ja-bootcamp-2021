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
// Dependency inversion principle is used in this program.
// Connection and database implement Interfaces, so they do not depend now from specific classes.
// So Databese can use different connections, User can get users from different databases.