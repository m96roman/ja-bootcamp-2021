using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database() { Name = "Nestor", LastName = "Pylat" };
            database.getInstance();
            database.getInstance();
            database.getInstance();
            database.getInstance();
        }
    }
}
