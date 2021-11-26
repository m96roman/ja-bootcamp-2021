using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ByItems : Shop
    {
        protected override void ExitFromYourPlace()
        {
            Console.WriteLine("get out of work");
        }

        protected override void GoToShop()
        {
            Console.WriteLine("go to supermarket");
        }
        protected override void TakeBasket()
        {
            Console.WriteLine("Take a basket");
        }
        protected override void GoToDepartments()
        {
            Console.WriteLine("go to departments");
        }
        protected override void GoToPay()
        {
            Console.WriteLine("Go to pay");
        }
        protected override void PayByCard()
        {
            Console.WriteLine("Pay by card visa");
        }
    }
}
