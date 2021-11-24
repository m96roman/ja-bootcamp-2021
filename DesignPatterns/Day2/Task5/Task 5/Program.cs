using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAccess database = new DatabaseAccess();

            Console.WriteLine(@$"Name is: {database.Instanse.Name}");
            Console.WriteLine(@$"LastName is: { database.Instanse.LastName}");
            Console.WriteLine(@$"Age is: {database.Instanse.Age}");
        }
    }
}
