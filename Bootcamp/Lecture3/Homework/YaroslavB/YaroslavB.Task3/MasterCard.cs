using System;

namespace YaroslavB.Task3
{
    public class MasterCard : CreditCard
    {
        public override string CardType => "MasterCard";

        public MasterCard(string bankOwner, long cardNumber) : this(bankOwner, cardNumber, "EUR") {}

        public MasterCard(string bankOwner, long cardNumber, string curency)
        {
            BankOwner = bankOwner;
            CardNumber = cardNumber;
            Curency = curency;
        }

        public override void BlockCard()
        {
            Console.WriteLine("Send command for blocking to MasterCard API");
        }

        public override double GetCardBalance()
        {
            Console.WriteLine("Send command to MasterCard API, return balance value");
            return 0.01;
        }

        public override void Payment(long destinationCard)
        {
            Payment(destinationCard, null);
        }

        public override void Payment(long destinationAccount, int? bankCode)
        {
            Console.WriteLine($"Create connection to MasterCard server, condact transaction with {BankOwner}");

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
                    "€80 000 has been deducted from your credit card.");
            }
        }

        private bool TryToPay(object connectionInstance)
        {
            //then gracefully trying to pay and return operation status...
            Random rd = new Random();
            return rd.Next(0, 1) == 1;
        }
    }
}
