using System;

namespace LiveCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var visaProcessor = new VisaPaymentProcessor();
            var masterCardProcessor = new MasterCardProcessor();

            visaProcessor.PayWithCard(new VisaCreditCard
            {
                Number = "432432",
                CVC = "1"
            });
            masterCardProcessor.PayWithCard(new MasterCardCreditCard
            {
                Number = "999",
                CVV = "99"
            });

            //2
            Print<int>(432);
            Print<double>(43.23);

            //3
            var pair1 = new Pair<int, string>();
            var pair2 = new Pair<string, CreditCard>();
        }

        public static void Print<T>(T obj)
        {
            Console.WriteLine(obj);
        }
    }

    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }

        public TValue Valu { get; set; }
    }

    public abstract class CreditCard
    {
        public string Number { get; set; }
    }

    public class VisaCreditCard : CreditCard
    {
        public string CVC { get; set; }
    }

    public class MasterCardCreditCard : CreditCard
    {
        public string CVV { get; set; }
    }

    public abstract class PaymentProcessor<T> where T : CreditCard
    {
        public void PayWithCard(T card)
        {
            var securityInfo = GetSecurityInfo(card);

            Console.WriteLine($"CardNumber: {card.Number}. Security: {securityInfo}");
        }

        protected abstract string GetSecurityInfo(T card);
    }

    public class VisaPaymentProcessor : PaymentProcessor<VisaCreditCard>
    {
        protected override string GetSecurityInfo(VisaCreditCard card)
        {
            return card.CVC;
        }
    }

    public class MasterCardProcessor : PaymentProcessor<MasterCardCreditCard>
    {
        protected override string GetSecurityInfo(MasterCardCreditCard card)
        {
            return card.CVV;
        }
    }
}
