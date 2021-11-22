using System;

namespace Task3
{
    public interface IFinancicReporter : IWorker
    {
        decimal Balance { get; set; }

        int CurrencyCode { get; set; }
        DateTime LastTimeAddedFundsToBalance { get; set; }

        void PaySalary();
    }
}