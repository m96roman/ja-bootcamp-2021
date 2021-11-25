using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class KievShip : Ship
    {
 
        public KievShip(Mediator mediator) : base(mediator)
        {
            this.Name = "Kiev";
        }

        public override void Notify(string message, string name)
        {
            Console.WriteLine($"{Name}:  {message} to {name}");
        }
        public override void Receive()
        {
            Console.WriteLine($"{Name} see the message");
        }
    }
}
