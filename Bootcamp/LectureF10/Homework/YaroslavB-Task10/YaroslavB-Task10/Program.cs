using System;

namespace SimulateGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office(new Git());
            office.StartWorkday();

            Console.WriteLine("Press \'Enter\' to exit");
            Console.ReadLine();
        }
    }
}
