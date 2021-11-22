using System;

namespace Task3
{
    public class FinanceReporter : Worker, IFinancicReporter
    {
        public DateTime LastTimeAddedFundsToBalance { get; set; }

        public int CurrencyCode { get; set; }

        public decimal Balance { get; set; }

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;

            LastTimeAddedFundsToBalance = new DateTime();
        }

        public void PaySalary()
        {
            Balance += Salary;
        }
    }
}
