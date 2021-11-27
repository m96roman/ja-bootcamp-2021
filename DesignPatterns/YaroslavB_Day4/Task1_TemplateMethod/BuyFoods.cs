using System;

namespace Task1_TemplateMethod
{
    class BuyFoods : GoShoppingTemplate
    {      
        protected override void GoOutside()
        {
            Console.WriteLine("1. Go out of work.");
        }

        protected override void GoToMarket()
        {
            Console.WriteLine("2. Go to supermarket.");
        }     

        protected override void TakeContainer()
        {
            Console.WriteLine("3. Take basket.");
        }

        protected override void GoThroughSections()
        {
            Console.WriteLine("4. Go through supermarket sections.");
        }

        protected override void ChooseGoods()
        {
            Console.WriteLine("5. Choose required foods.");
        }

        protected override void GoToСashRegister()
        {
            Console.WriteLine("6. Go to cach register.");
        }

        protected override void PayForGoods()
        {
            Console.WriteLine("7. Pay by credit card.");
        }

        protected override void DeliverHome()
        {
            Console.WriteLine("8. Take foods home.");
        }
    }
}
