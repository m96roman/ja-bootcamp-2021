using System;

namespace Task5_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstShip firstShip = new FirstShip();
            SecondShip secondShip = new SecondShip();
            ThirdShip thirdShip = new ThirdShip();
            Operator sender = new Operator(firstShip, secondShip, thirdShip);

            sender.Notify(firstShip);
            Console.WriteLine("------------------");
            sender.Notify(secondShip);
            Console.WriteLine("------------------");
            sender.Notify(thirdShip);
        }
    }
}
