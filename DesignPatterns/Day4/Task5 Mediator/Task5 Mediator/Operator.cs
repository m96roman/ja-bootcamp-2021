using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_Mediator
{
    public class Operator : IMediator
    {
        public FirstShip FirstShip;
        public SecondShip SecondShip;
        public ThirdShip ThirdShip;

        public Operator(FirstShip firstShip, SecondShip secondShip, ThirdShip thirdShip)
        {
            FirstShip = firstShip;
            SecondShip = secondShip;
            ThirdShip = thirdShip;
        }

        public void Notify(BaseShip ship)
        {
            if (ship.GetType() == typeof(FirstShip))
            {
                FirstShip.SendMessageToSecond();
                FirstShip.SendMessageToThird();
            }
            else if (ship.GetType() == typeof(SecondShip))
            {
                SecondShip.SendMessageToFirst();
                SecondShip.SendMessageToThird();
            }
            else if (ship.GetType() == typeof(ThirdShip))
            {
                ThirdShip.SendMessageToSecond();
                ThirdShip.SendMessageToFirst();
            }
        }
    }
}
