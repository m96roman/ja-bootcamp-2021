using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Present : ShoppingTemplate
    {     
        public override void ChoosePlace()
        {
            Console.WriteLine("Go to store with presents");
        }

        public override void ChooseWhatYouNeed()
        {
            Console.WriteLine("Choose present");
        }

        public override void PayForItems()
        {
            Console.WriteLine("Pay with credit card");
        }

        public override void PrepareForShopping()
        {
            Console.WriteLine("Go out from home");
        }

        public override void TakeHome()
        {
            Console.WriteLine("Take your purchase home");
        }
    }
}
