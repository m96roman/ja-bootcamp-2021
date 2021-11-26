using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Groceries : ShoppingTemplate
    {
        public override void ChoosePlace()
        {
            Console.WriteLine("Go to supermarket");
        }

        public override void ChooseWhatYouNeed()
        {
            Console.WriteLine("Choose present");
        }

        public override void TakeCart()
        {
            Console.WriteLine("Take cart for shopping");
        }

        public override void ScoutDepartments()
        {
            Console.WriteLine("Go through departments");
        }

        public override void PayForItems()
        {
            Console.WriteLine("Pay with cash");
        }

        public override void PrepareForShopping()
        {
            Console.WriteLine("Go out from work");
        }

        public override void TakeHome()
        {
            Console.WriteLine("Take your purchase home");
        }

        public override void GoToCheckOut()
        {
            Console.WriteLine("Go to check out");
        }
    }
}
