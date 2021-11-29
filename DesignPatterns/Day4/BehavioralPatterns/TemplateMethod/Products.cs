using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Products : Purchase
    {
        public override void GetOut()
        {
            Console.WriteLine("Get out of work");
        }

        public override void GoToThe()
        {
            Console.WriteLine("Go to the market");
        }


        public override void Pay()
        {
            Console.WriteLine("Pay by card");
        }

        public override void TakeTheBasket()
        {
            Console.WriteLine("Take the basket");
        }

        public override void WalkThroughTheDepartments()
        {
            Console.WriteLine("Walk through the departments");
        }

        public override void GoToTheCheckout()
        {
            Console.WriteLine("Go to the checkout");
        }
    }
}
