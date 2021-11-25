using System;
using ConsoleApp2.Enums;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Decorator */

            Computer workComputer = new WorkComputer("Dell", ComputerTypes.Work);
            Console.WriteLine(workComputer.ToString());

            Computer officeComputer1 = new OfficeComputer("Asus", ComputerTypes.Office);
            officeComputer1 = new WiFiDecorator(officeComputer1);
            Console.WriteLine(officeComputer1.ToString());

            Computer officeComputer2 = new OfficeComputer("HP", ComputerTypes.Office);
            officeComputer2 = new LightDecorator(officeComputer2);
            Console.WriteLine(officeComputer2.ToString());

            Computer gameComputer = new GameComputer("MSI", ComputerTypes.Game);
            gameComputer = new LightDecorator(gameComputer);
            gameComputer = new WiFiDecorator(gameComputer);
            Console.WriteLine(gameComputer.ToString());
        }
    }
}
