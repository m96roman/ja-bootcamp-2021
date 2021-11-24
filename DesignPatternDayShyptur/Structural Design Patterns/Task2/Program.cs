using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new ComputerOffice();
            Console.WriteLine(computer.name);
            computer = new WithWiFi(computer);
            Console.WriteLine(computer.name);
           
            computer = new WithLight(computer);
            Console.WriteLine(computer.name);
            Console.ReadLine();
        }
    }
}
