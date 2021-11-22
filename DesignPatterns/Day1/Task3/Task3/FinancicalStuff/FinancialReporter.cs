using System;

namespace Task3
{
    public class FinancialReporter : IFinancialReporter
    {
        public DateTime LastTimeAddedFundsToBalance { get; set; }

        public IFinanceBalance FinanceBalance { get; set; }

        public IPerson Person { get; set; }

        public string GetFullName() => Person.GetFullName();

        public void IncreaseBalance(decimal amount)
        {
            FinanceBalance.Balance += amount;

            LastTimeAddedFundsToBalance = new DateTime();
        }

        public void IncreaseSalary(decimal diff)
        {
            FinanceBalance.Salary += diff;
        }

        public void PaySalary()
        {
            FinanceBalance.Balance += FinanceBalance.Salary;
        }
    }
}
