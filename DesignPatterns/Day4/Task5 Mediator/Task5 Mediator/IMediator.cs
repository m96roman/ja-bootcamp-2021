using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
    public interface IMediator
    {
        void Notify(BaseShip ship);
    }
}
