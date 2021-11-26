using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Ship 
    {
        protected IMediator Mediator { get; set; }

        public string Name { get; set; }

        public Ship(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public void SendMassege(string message, string addressee)
        {
            Console.WriteLine($"{Name}: send  {message} to {addressee}");

            this.Mediator.SendToDespetcher(message, this, addressee);
        }       

        public void ResiveMessage() 
        {
            Console.WriteLine($"{Name} get the message");
        }
    }
}
