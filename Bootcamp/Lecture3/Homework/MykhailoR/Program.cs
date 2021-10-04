using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MykhailoR
{
    class Program
    {
        static void Main(string[] args)
        {
            VisaCreditCard visa = new VisaCreditCard();

            MasterCardCreditCard mastercard = new MasterCardCreditCard();

            CreditCard[] cards = new CreditCard[] { new MasterCardCreditCard(), new VisaCreditCard() };

            foreach (var creditCard in cards)
            {
                Console.WriteLine(creditCard.GetInformation());
                creditCard.Pay();
                Console.WriteLine("____________________");
            }
        }


        static void PrintCard(CreditCard card)
        {
            card.Pay();
        }
    }

    public abstract class PaymentMethod
    {
        public abstract void Pay();
    }

    public class PayPal : PaymentMethod
    {
        public override void Pay()
        {

        }
    }

    public abstract class CreditCard : PaymentMethod
    {
       public string Number { get; set; }

       protected abstract string CardType { get;  }

       protected CreditCard(string number)
       {
       }

       public string GetInformation()
       {
           return $"It's {CardType} with number {Number}";
       }
    }


    public class VisaCreditCard : CreditCard
    {
        public VisaCreditCard() : base("432432432")
        {
        }

        protected override string CardType
        {
            get
            {
                return "VISA";
            }
        }

        public override void Pay()
        {
            Console.WriteLine("Pay with Visa");
        }
    }

    public class MasterCardCreditCard : CreditCard
    {
        public MasterCardCreditCard() : base("fjdsakfjsdal")
        {
        }

        protected override string CardType
        {
            get
            {
                return "Mastercard";
            }
        }

        public override void Pay()
        {
            Console.WriteLine("Pay with MasterCard");
        }
    }
}
