using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractComputer computer1 = new ComputerFirst("Office");
            computer1 = new ComputerWithWiFi(computer1);
            computer1 = new BackLight(computer1);
            Console.WriteLine(computer1.Name);

            AbstractComputer computer2 = new ComputerSecond("Home");
            computer2 = new ComputerWithWiFi(computer2);

            Console.WriteLine(computer2.Name);
        }
    }
}
