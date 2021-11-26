using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            MainOperator mainOperator = new MainOperator();
            Captain captainKyiv = new CaptainKyiv(mainOperator);
            Captain captainLviv = new CaptainLviv(mainOperator);
            Captain captainUzh = new CaptainUzhgorod(mainOperator);

            mainOperator.CaptainKyiv = captainKyiv;
            mainOperator.CaptainLviv = captainLviv;
            mainOperator.CaptainUzh = captainUzh;

            captainKyiv.SendMessage("some");
        }
    }
}
