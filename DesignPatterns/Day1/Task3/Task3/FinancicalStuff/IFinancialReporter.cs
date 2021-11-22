using System;

namespace Task3
{
    public interface IFinancialReporter
    {
        decimal Balance { get; set; }

        int CurrencyCode { get; set; }

        DateTime LastTimeAddedFundsToBalance { get; set; }

        decimal Salary { get; set; }

        void PaySalary();

        string GetFullName();

        void IncreaseSalary(decimal diff);
    }
}