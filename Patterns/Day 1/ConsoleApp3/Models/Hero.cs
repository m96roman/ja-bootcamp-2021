using ConsoleApp3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    public class Hero
    {
        public string Alias { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Power { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostIndex { get; set; }
        public string Country { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }
        public int CurrencyCode { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastTimeAddedFundsToBalance { get; set; }
    }
}
