using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class Purchase
    {
        public void Shopping()
        {
            GetOut();
            GoToThe();
            TakeTheBasket();
            WalkThroughTheDepartments();
            ChooseProduct();
            GoToTheCheckout();
            Pay();
            OrderDeliveryService();
            BringHome();
        }

        public abstract void GetOut();

        public abstract void GoToThe();

        private void ChooseProduct()
        {
            Console.WriteLine("Choose want need");
        }

        public virtual void TakeTheBasket(){}

        public virtual void WalkThroughTheDepartments() { }

        public virtual void GoToTheCheckout() { }

        public abstract void Pay();

        private void BringHome()
        {
            Console.WriteLine("Bring to home");
        }

        public virtual void OrderDeliveryService(){}
    }
}
