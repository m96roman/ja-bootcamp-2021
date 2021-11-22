using System;

namespace Task3
{
    public interface IFinancicReporter
    {
        decimal Balance { get; set; }

        int CurrencyCode { get; set; }

        DateTime LastTimeAddedFundsToBalance { get; set; }

        void PaySalary();

        string GetFullName();
        void IncreaseSalary(decimal diff);
    }
}