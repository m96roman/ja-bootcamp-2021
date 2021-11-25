using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Security luckyMan = new Security
            {
                Balance = 5.0M,
                City = "NY",
                Country = "US",
                CurrencyCode = 124,
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                LastTimeAddedFundsToBalance = DateTime.MinValue,
                PostIndex = "PO 90555",
                Salary = 15.0M,
                Street = "1st ave",
                Weapon = "shocker"
            };

            var financialDepartment = new FinancialDepartment();
            financialDepartment.ShowBalance(luckyMan);
            financialDepartment.IncreaseSalary(luckyMan, 1M);
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(luckyMan, 0.5M);
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyMan);
            var security = new Security();
            security.Check(luckyMan, luckyMan.Weapon);
            Console.ReadLine();

            // Liskov substitution principle - Hero or Security should be able to replace Person
        }
    }
}
