using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_Template
{
    public abstract class Shoping
    {
        protected abstract void Exit();

        protected abstract void GoFor();

        protected virtual void TakeBag() { }

        protected virtual void GoThrow() { }

        protected void ChooseSmth()
        {
            Console.WriteLine("Chosen");
        }

        protected virtual void GoToPay() { }

        protected virtual void AskForABill() { }

        protected virtual void PayWithCard() { }

        protected virtual void Delivery() { }

        protected void GoHome() {
            Console.WriteLine("Come back home");
        }

        public void GoShopping()
        {
            Exit();
            GoFor();
            TakeBag();
            GoThrow();
            ChooseSmth();
            GoToPay();
            AskForABill();
            PayWithCard();
            Delivery();
            GoHome();
        }
    }
}
