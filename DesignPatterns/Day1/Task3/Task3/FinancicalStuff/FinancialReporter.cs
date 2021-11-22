using System;

namespace Task3
{
    public class FinancialReporter : IFinancialReporter
    {
        public DateTime LastTimeAddedFundsToBalance { get; set; }

        public int CurrencyCode { get; set; }

        public decimal Balance { get; set; }

        public decimal Salary { get; set; }

        public IPerson Person { get; set; }

        public void DecreaseSalary(decimal amount)
        {
            throw new NotImplementedException();
        }

        public string GetFullName() => Person.GetFullName();

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;

            LastTimeAddedFundsToBalance = new DateTime();
        }

        public void IncreaseSalary(decimal diff)
        {
            Salary += diff;
        }

        public void PaySalary()
        {
            Balance += Salary;
        }
    }
}
