using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Template
{
    class GoForProducts : Shoping
    {
        protected override void Exit()
        {
            Console.WriteLine("Leave work");
        }

        protected override void GoFor()
        {
            Console.WriteLine("Supermarket");
        }

        protected override void TakeBag()
        {
            Console.WriteLine("Take bag");
        }

        protected override void GoThrow()
        {
            Console.WriteLine("Go throw supermarket");
        }

        protected override void GoToPay()
        {
            Console.WriteLine("Go to pay");
        }

        protected override void PayWithCard()
        {
            Console.WriteLine("Pay by card");
        }
    }
}
