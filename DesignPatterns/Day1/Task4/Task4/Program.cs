using System;

namespace Task4
{
    //Dependency inversion principle was violated
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
