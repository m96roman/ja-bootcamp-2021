using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Template
{
    class GoForFurniture : Shoping
    {
        protected override void Exit()
        {
            Console.WriteLine("Exit home");
        }

        protected override void GoFor()
        {
            Console.WriteLine("Go Shop");
        }

        protected override void AskForABill()
        {
            Console.WriteLine("Ask for a bill");
        }

        protected override void Delivery()
        {
            Console.WriteLine("Ask for delivery");
        }
    }
}
