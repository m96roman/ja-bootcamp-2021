using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer officeComputer = new OfficeComputer();
            officeComputer = new ComputerWithWiFi(officeComputer);
            Console.WriteLine("Name: {0}", officeComputer.Name);

            Computer workComputer = new WorkComputer();
            workComputer = new ComputerWithWiFi(workComputer);
            Console.WriteLine("Name: {0}", workComputer.Name);

            Computer gameComputer = new GameComputer();
            gameComputer = new ComputerWithWiFi(gameComputer);
            gameComputer = new ComputerWithBackLight(gameComputer);
            Console.WriteLine("Name: {0}", gameComputer.Name);

        }
    }
}
