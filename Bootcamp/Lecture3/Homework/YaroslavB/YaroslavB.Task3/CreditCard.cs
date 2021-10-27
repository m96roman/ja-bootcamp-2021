namespace YaroslavB.Task3
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; }

        public long CardNumber { get; protected set; }

        public string BankOwner { get; protected set; }

        public string Curency { get; protected set; } = "USD";

        public virtual bool DoubleCurencyСonversion { get; } = false;

        public abstract void Payment(long destinationCard);

        public abstract void Payment(long destinationAccount, int? bankCode);

        public abstract void BlockCard();

        public abstract double GetCardBalance();
    }
}
