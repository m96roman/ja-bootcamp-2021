using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class ShoppingTemplate
    {
        public void ShoppingTemplateSimulation()
        {
            this.PrepareForShopping();
            this.ChoosePlace();
            this.TakeCart();
            this.ChooseWhatYouNeed();
            this.GoToCheckOut();
            this.PayForItems();
            this.CallForDelivery();
            this.TakeHome();
        }

        public abstract void PrepareForShopping();
        public abstract void ChoosePlace();
        public virtual void ScoutDepartments() { }
        public virtual void TakeCart() { }
        public abstract void ChooseWhatYouNeed();
        public virtual void GoToCheckOut() { }
        public abstract void PayForItems();
        public virtual void CallForDelivery() { }
        public abstract void TakeHome();
    }
}
