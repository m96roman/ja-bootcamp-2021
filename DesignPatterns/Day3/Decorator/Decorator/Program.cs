using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputer> computers = new List<IComputer>() 
            {
                new Computer("GameComputer"),
                new Computer("WorkComputer"),
                new Computer("OfficeComputer")
            };

            foreach (var computer in computers) 
            {
                computer.Info();
            }

            var decorator = new Decorator(computers[0], new ComputerConfig() { WifiAdapter = true, KeyboardBacklight = true });
            decorator.Info();

            decorator = new Decorator(computers[1], new ComputerConfig() { WifiAdapter = false, KeyboardBacklight = false });
            decorator.Info();

            decorator = new Decorator(computers[2], new ComputerConfig() { WifiAdapter = true, KeyboardBacklight = false });
            decorator.Info();
        }
    }
}
