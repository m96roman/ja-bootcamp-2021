using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //First of all, the mysqlConnnection/mysqlContext has to be passed as absctracts, not realizations
            //So instead we pass ISqlConnection/IDbContext
            //And IRepository is here just for usability
            IRepository<User> repo = new UserRepository(
                    new MySqlContext<User>(new MySqlConnection()));

            Console.WriteLine($"Users count {repo.GetEntities().Count}");
            Console.ReadLine();
        }
    }
}
