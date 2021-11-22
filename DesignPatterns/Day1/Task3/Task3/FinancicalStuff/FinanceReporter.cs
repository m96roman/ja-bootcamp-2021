using System;

namespace Task3
{
    //I ignored SPR here from practical reasons, two departments use same method increase salary\decrease salary
    //sure if we change some logic in hr department, the finance department logic will crush but in other hand the logic in two departments is pretty same
    //I think if we will need to change something in HR or Fin, which change logic completly, then and only then we will follow SPR 
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
