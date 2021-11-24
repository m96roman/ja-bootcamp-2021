using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new OfficeModel();
            computer = new OptionalWifi(computer);

            Console.WriteLine($"{computer.Type}");
        }
    }
}
