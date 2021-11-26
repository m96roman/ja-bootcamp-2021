using System;

namespace ConsoleApp3.Models
{
    public abstract class Worker : Person
    {
        public decimal Salary { get; set; }
        public int CurrencyCode { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastTimeAddedFundsToBalance { get; set; }
    }
}
