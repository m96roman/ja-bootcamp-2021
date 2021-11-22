using System;

namespace Task3
{
    public interface IFinancialReporter
    {
        IFinanceBalance FinanceBalance { get; set; }

        DateTime LastTimeAddedFundsToBalance { get; set; }

        void PaySalary();

        string GetFullName();

        void IncreaseSalary(decimal diff);
    }
}