using System;

namespace YaroslavB.Task3
{
    public class VisaCard : CreditCard
    {

        public override string CardType => "VisaCard";

        public override string BankOwner { get; }

        public override long CardNumber { get; }

        public override string Curency { get; }

        public string CardPurpose { get; set; }

        public VisaCard(string bankOwner, long cardNumber) : this(bankOwner, cardNumber, "USD")
        {
            
        }

        public VisaCard(string bankOwner, long cardNumber, string curency)
        {
            BankOwner = bankOwner;

            CardNumber = cardNumber;

            Curency = curency;

        }


        public override void BlockCard()
        {
            Console.WriteLine("Send command for blocking to Visa API");
        }

        public override double GetCardBalance()
        {
            Console.WriteLine("Send command to Visa API, return balance value");
            return 0.01;
        }

        public override void Payment(long destinationCard)
        {
            Payment(destinationCard, null);
        }

        public override void Payment(long destinationAccount, int? bankCode = null)
        {
            Console.WriteLine($"Create connection to Visa server, condact transaction with {BankOwner}");

            object connectionInstance = "pay bank account";

            if(bankCode == null)
            {
                connectionInstance = "pay to card";
            }

            if(!TryToPay(connectionInstance))
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

            return rd.Next(0, 1) == 1 ? true : false;
        }

       
    }
}
