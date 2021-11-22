using System;

namespace Task3
{
    public class GreetingsSender : Person, IGreetingSender
    {
        public string PostIndex { get; private set; }

        public string Street { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public void SendGreeting(string text)
        {
            string destination = $"{PostIndex} {Street}, {City}, {Country}";
            Console.WriteLine($"Sending letter with context '{text}' to destination {destination}");
        }
    }

    //public DateTime LastTimeAddedFundsToBalance { get; set; }
    //public string Alias { get; set; }
    //public string Power { get; set; }
    //public string City { get; set; }
    //public string Street { get; set; }
    //public string PostIndex { get; set; }
    //public string Country { get; set; }

    //public int CurrencyCode { get; set; }
    //public decimal Balance { get; set; }


    //public void IncreaseBalance(decimal amount)
    //{
    //    Balance += amount;
    //}

    //public void PaySalary()
    //{
    //    Balance += Salary;
    //}


}
