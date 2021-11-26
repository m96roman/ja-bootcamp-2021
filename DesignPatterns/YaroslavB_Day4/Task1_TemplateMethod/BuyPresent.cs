using System;

namespace Task1_TemplateMethod
{
    class BuyPresent : GoShoppingTemplate
    {
        protected override void GoOutside()
        {
            Console.WriteLine("1. Go out of home.");
        }

        protected override void GoToMarket()
        {
            Console.WriteLine("2. Go to the mall.");
        }

        protected override void ChooseGoods()
        {
            Console.WriteLine("3. Choose some present.");
        }


        protected override void PayForGoods()
        {
            Console.WriteLine("4. Pay by credit card.");
        }

        protected override void DeliverHome()
        {
            Console.WriteLine("5. Take the present home.");
        }
    }
}
