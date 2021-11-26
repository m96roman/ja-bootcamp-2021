namespace ConsoleApp1
{
    public abstract class Buy
    {
        public void PerformBuy()
        {
            ExitFromHome();
            GoToThe();
            TakeBasket();
            GoThroughtDepartments();
            Choose();
            GetCheque();
            GoToThePayDeck();
            PayByCreditCard();
            OrderDelivery();
            BringToHome();
        }

        public abstract void ExitFromHome();
        public abstract void GoToThe();
        public abstract void Choose();

        public abstract void BringToHome();
        public virtual void TakeBasket() { }
        public virtual void GoThroughtDepartments() { }
        public virtual void GoToThePayDeck() { }
        public virtual void GetCheque() { }
        public virtual void PayByCreditCard() { }
        public virtual void OrderDelivery() { }
    }
}
