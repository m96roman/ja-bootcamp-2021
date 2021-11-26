using System;

namespace Task4
{
    // Частково вже описав в першому таску тут так само  Dependency inversion -UserRepository напрячу залежить від MySqlConnection
    // може бути ситуація що нам треба буду юзати іншу базу тоді треба буде міняти багато коду краще зробити один Інтерфейс для всі баз
    // Так само доданий інтерфейс до MySqlDb
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
