using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputer officeComputer = new Computer(ComputerType.Office);
            IComputer gameComputer = new Computer(ComputerType.Game);
            IComputer workComputer = new Computer(ComputerType.Work);

            officeComputer.PrintInfo();
            gameComputer.PrintInfo();
            workComputer.PrintInfo();
            Console.WriteLine();
            IComputer computerDecorator = new ComputerDecorator(officeComputer, hasWifi: true);

            computerDecorator.PrintInfo();

            Console.WriteLine();

            computerDecorator = new ComputerDecorator(gameComputer, hasWifi: true, hasLight: true);

            computerDecorator.PrintInfo();

            Console.WriteLine();

            computerDecorator = new ComputerDecorator(workComputer);

            computerDecorator.PrintInfo();
        }
    }
}
