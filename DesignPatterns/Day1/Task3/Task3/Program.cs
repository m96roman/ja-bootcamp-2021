using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the principle of interface separation
//

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero luckyMan = new Hero
            {
                Alias = "Luckyman",
                Balance = 5.0M,
                City = "NY",
                Country = "US",
                CurrencyCode = 124,
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                LastTimeAddedFundsToBalance = DateTime.MinValue,
                PostIndex = "PO 90555",
                Power = "Luck",
                Salary = 15.0M,
                Street = "1st ave"                
            };

            var financialDepartment = new FinancialDepartment();
            financialDepartment.ShowBalance(luckyMan);
            luckyMan.IncreaseSalaryAndMessage( 1M);
            var hrDepartment = new HrDepartment();
            luckyMan.IncreaseSalaryAndMessage( 0.5M);
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyMan);
            Console.ReadLine();
        }
    }
}
