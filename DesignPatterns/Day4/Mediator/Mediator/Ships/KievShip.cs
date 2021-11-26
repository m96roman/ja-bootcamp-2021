using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Ships
{
    class KievShip : Ship
    {
        public KievShip(IMediator mediator) : base(mediator)
        {
            this.Name = "KievShip";
        }
    }
}
