using System;

namespace YaroslavB.Task3
{
    public class VisaCardUkraine : VisaCard
    {      
        public override string CardType => "VisaCard Ukraine";

        public override bool DoubleCurencyСonversion => true;

        public VisaCardUkraine(string bankName, long cardNumber, string curency) : base(bankName, cardNumber, curency) {}

        public override double GetCardBalance()
        {
            Console.WriteLine("Send command to Visa API, return balance value");
            return -5000.00;
        }

        public override void Payment(long destinationAccount, int? bankCode = null)
        {
            Console.WriteLine($"Create connection to unknown server in Strabychovo village, condact transaction with {BankOwner}");

            object connectionInstance = "pay bank account";

            if (bankCode == null)
            {
                connectionInstance = "pay to card";
            }

            if (!TryToPay(connectionInstance))
            {
                Console.WriteLine($"Error! Operation intrupted, please doublecheck your balance,\n" +
                                $"you may use for that our special function - {nameof(GetCardBalance)} :))");
            }
            else
            {
                Console.WriteLine("Successful operation!\n" +
                    "$50 000 has been deducted from your credit card.");
            }
        }

        private bool TryToPay(object connectionInstance)
        {
            //then gracefully trying to pay and return operation status...
            Random rd = new Random();
            return rd.Next(0, 10) < 9;
        }
    }
}
