using System;

namespace ConsoleApp1
{
    public class SupermarketBuy : Buy
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
            Console.WriteLine("Exit from work");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the supermarket");
        }

        public override void PayByCreditCard()
        {
            Console.WriteLine("Pay by credit card");
        }

        public override void TakeBasket()
        {
            Console.WriteLine("Take basket");
        }

        public override void GoThroughtDepartments()
        {
            Console.WriteLine("Go throught departments");
        }

        public override void GoToThePayDeck()
        {
            Console.WriteLine("Go to the payback");
        }
    }
}
