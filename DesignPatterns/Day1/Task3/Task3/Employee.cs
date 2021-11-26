using System;

namespace Task3
{
    public class Employee
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
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
