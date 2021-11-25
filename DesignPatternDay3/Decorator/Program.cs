using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new HomeComputer("home");
            ComputerDecorator computerWithWifi = new WifiDecorator(computer1);

            Console.WriteLine($"{computerWithWifi._type } Price is: {computerWithWifi.Price()}.");

            Computer computer2 = new OfficeComputer("office");
            ComputerDecorator computerWithBacklight = new BacklightDecorator(computer2);

            Console.WriteLine($"{computerWithBacklight._type } Price is: {computerWithBacklight.Price()}.");

            Computer computer3 = new GameComputer("game");
            ComputerDecorator computerWithBacklight2 = new BacklightDecorator(computer3);

            Console.WriteLine($"{computerWithBacklight2._type } Price is: {computerWithBacklight2.Price()}.");
        }
    }
}
