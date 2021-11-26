using System;

namespace ConsoleApp1
{
    public class ShoppingCentreBuy : Buy
    {
        public override void BringToHome()
        {
            Console.WriteLine("Bring to home");
        }

        public override void Choose()
        {
            Console.WriteLine("Choose what you need");
        }

        public override void ExitFromHome()
        {
            Console.WriteLine("Exit from home");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the shopping centre");
        }

        public override void PayByCreditCard()
        {
            Console.WriteLine("Pay by credit card");
        }
    }
}
