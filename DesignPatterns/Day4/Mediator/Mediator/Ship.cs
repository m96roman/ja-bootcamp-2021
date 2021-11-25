using System;

namespace Mediator
{
    public class Ship : INavigable
    {
        public string Name { get; set; }

        public IDispatcher Dispatcher { get; set; }

        public void SetMediator(IDispatcher dispetcher)
        {
            this.Dispatcher = dispetcher;
        }

        public void Maneuver(string message)
        {
            Console.WriteLine($"{Name} understood and will '{message}'");
            Console.WriteLine("*Brrr*");
        }
    }
}