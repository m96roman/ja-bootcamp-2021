using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamplateMethod
{
    public abstract class ShoppingTrip
    {
        public void ShoppingTeamplate()
        {
            this.RequiredGoOut();
            this.RequiredGoToThe();
            this.HookTakeBasket();
            this.HookGoThroughDepartments();
            this.ChooseSomething();
            this.HookGoToCashRegister();
            this.RequiredPayBuy();
            this.HookOrderDeliveryService();
            this.BringToHome();
        }

        // These operations already have implementations.
        protected void BringToHome() 
        {
            Console.WriteLine("Bring home");
        }
        protected void ChooseSomething() 
        {
            Console.WriteLine("Choose something");
        }

        // These operations have to be implemented in subclasses.
        // Required
        protected abstract void RequiredGoOut();
        protected abstract void RequiredGoToThe();
        protected abstract void RequiredPayBuy();

        // Hooks
        protected virtual void HookTakeBasket() { }
        protected virtual void HookGoThroughDepartments() { }
        protected virtual void HookGoToCashRegister() { }
        protected virtual void HookOrderDeliveryService() { }
    }
}
