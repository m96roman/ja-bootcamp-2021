using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Template
{
    class Present : Shoping
    {
        protected override void Exit()
        {
            Console.WriteLine("Exit home");
        }

        protected override void GoFor()
        {
            Console.WriteLine("Go for Shopping Center");
        }

        protected override void PayWithCard()
        {
            Console.WriteLine("Pay by card");
        }
    }
}
