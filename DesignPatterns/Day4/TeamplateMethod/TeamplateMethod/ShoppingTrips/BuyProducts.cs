using System;

namespace TeamplateMethod.ShoppingTrips
{
    class BuyProducts : ShoppingTrip
    {
        protected override void RequiredGoOut()
        {
            Console.WriteLine("Get out of the work");
        }

        protected override void RequiredGoToThe()
        {
            Console.WriteLine("Go to the supermarket");
        }

        protected override void RequiredPayBuy()
        {
            Console.WriteLine("Pay buy credit cart ");
        }

        protected override void HookTakeBasket() 
        {
            Console.WriteLine("Take basket");
        }

        protected override void HookGoThroughDepartments() 
        {
            Console.WriteLine("Go through departments");
        }

        protected override void HookGoToCashRegister()
        {
            Console.WriteLine("Go to the cash register");
        }      
    }
}
