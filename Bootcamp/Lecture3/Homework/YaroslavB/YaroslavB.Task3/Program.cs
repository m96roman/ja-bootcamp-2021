using System;
using System.Collections.Generic;

namespace YaroslavB.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            VisaCard newVisa = new VisaCard("Bank of America", 1234565457)
            {
                CardPurpose = "Private card"
            };

            VisaCard workerVisa = new VisaCard("Deutsche Bank", 3452754253, "EUR")
            {
                CardPurpose = "Business card"
            };

            VisaCardUkraine visaUkrane = new VisaCardUkraine("PrivatBank", 3457623466, "UAH")
            {
                CardPurpose = "Private card"
            };

            List<CreditCard> listOfCard = new List<CreditCard>() { newVisa, workerVisa, visaUkrane };

            foreach (var item in listOfCard)
            {
                Console.WriteLine($" Card type: {item.CardType},\n" +
                                $" card number: {item.CardNumber},\n" +
                                $" managed by {item.BankOwner},\n" +
                                $" curency: {item.Curency},\n" +
                                $" double conversion is required: {item.DoubleCurencyСonversion} ");

                Console.WriteLine("\nNow let's pay for electricity...");

                if(item.CardType == "VisaCard Ukraine")
                {
                    item.Payment(3546844133, 64008);
                }
                else
                {
                    item.Payment(3513145315);
                }

                Console.WriteLine($"Checking card balance.......\n" +
                    $"available balance: {item.GetCardBalance()}");
                
                
                Console.Write("------------------------------------------\n\n\n");
            }

            Console.WriteLine("Press \'Enter\' to exit...");

            Console.ReadLine();
        }
    }



   
}
