using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Shop
    {
        public void SimulateShopping()
        {
            this.ExitFromYourPlace();
            this.GoToShop();
            this.TakeBasket();
            this.GoToDepartments();
            this.ChooseItems();
            this.GoToPay();
            this.WriteReceipt();
            this.PayByCard();
            this.OrderDeliveryService();
            this.ComeBackToHome();


        }
        protected abstract void ExitFromYourPlace();
        protected abstract void GoToShop();
        protected virtual void TakeBasket() { }
        protected virtual void GoToDepartments() { }
        protected void ChooseItems()
        {
            Console.WriteLine("Choose items");
        }
        protected void ComeBackToHome()
        {
            Console.WriteLine("Go home");
        }
        protected virtual void PayByCard() { }
        protected virtual void GoToPay() { }
        protected virtual void WriteReceipt() { }
        protected virtual void OrderDeliveryService() { }


    }
}
