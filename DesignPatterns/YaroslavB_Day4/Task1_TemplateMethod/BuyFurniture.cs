using System;

namespace Task1_TemplateMethod
{
    class BuyFurniture : GoShoppingTemplate
    {
        protected override void GoOutside()
        {
            Console.WriteLine("1. Go out of home.");
        }

        protected override void GoToMarket()
        {
            Console.WriteLine("2. Go to furniture market.");
        }

        protected override void ChooseGoods()
        {
            Console.WriteLine("3. Choose required furniture.");
        }

        protected override void PayForGoods()
        {
            Console.WriteLine("4. Write a check.");
        }

        protected override void TakeTransport()
        {
            Console.WriteLine("5. Order delivery servise.");
        }

        protected override void DeliverHome()
        {
            Console.WriteLine("6. Take foods home.");
        }
    }
}
