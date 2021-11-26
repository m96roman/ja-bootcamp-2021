using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        void SendToDespetcher(string message, Ship ship, string addressee);
    }
}
