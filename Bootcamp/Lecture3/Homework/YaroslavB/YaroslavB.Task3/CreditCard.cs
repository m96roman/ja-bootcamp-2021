namespace YaroslavB.Task3
{
    public abstract class CreditCard
    {
        //private string _cardName;

        public abstract long CardNumber { get; }

        public abstract string CardType { get; }

        public abstract string BankOwner { get; }

        public virtual string Curency { get; } = "USD";

        public virtual bool DoubleCurencyСonversion { get; } = false;

        public abstract void Payment(long destinationCard);

        public abstract void Payment(long destinationAccount, int? bankCode);

        public abstract void BlockCard();

        public abstract double GetCardBalance();


    }
}
