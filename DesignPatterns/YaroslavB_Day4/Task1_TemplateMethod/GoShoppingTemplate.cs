namespace Task1_TemplateMethod
{
    abstract class GoShoppingTemplate
    {
        public void GoShopping()
        {
            GoOutside();
            GoToMarket();
            TakeContainer();
            GoThroughSections();
            ChooseGoods();
            GoToСashRegister();
            PayForGoods();
            TakeTransport();
            DeliverHome();
        }

        protected abstract void GoOutside();

        protected abstract void GoToMarket();

        protected virtual void TakeContainer() { }

        protected virtual void GoThroughSections() { }

        protected abstract void ChooseGoods();

        protected virtual void GoToСashRegister() { }

        protected abstract void PayForGoods();

        protected virtual void TakeTransport() { }

        protected abstract void DeliverHome();
    }
}
