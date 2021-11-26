using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Furniture : ShoppingTemplate
    {
        public override void CallForDelivery()
        {
            Console.WriteLine("Call delivery service");
        }

        public override void ChoosePlace()
        {
            Console.WriteLine("Go to furniture store");
        }

        public override void ChooseWhatYouNeed()
        {
            Console.WriteLine("Choose furniture");
        }

        public override void PayForItems()
        {
            Console.WriteLine("Write check");
        }

        public override void PrepareForShopping()
        {
            Console.WriteLine("Go out from home");
        }

        public override void TakeHome()
        {
            Console.WriteLine("Take your purchase home");
        }

        public virtual void CallForDelivery()
        {
            Console.WriteLine("Call delivery service");
        }
    }
}
