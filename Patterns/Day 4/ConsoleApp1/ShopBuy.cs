using System;

namespace ConsoleApp1
{
    public class ShopBuy : Buy
    {
        public override void BringToHome()
        {
            Console.WriteLine("Bring furniture to home");
        }

        public override void Choose()
        {
            Console.WriteLine("Choose furniture");
        }

        public override void ExitFromHome()
        {
            Console.WriteLine("Exit from home");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the shop");
        }

        public override void GetCheque()
        {
            Console.WriteLine("Get cheque from shop");
        }

        public override void OrderDelivery()
        {
            Console.WriteLine("Order delivery service");
        }
    }
}
