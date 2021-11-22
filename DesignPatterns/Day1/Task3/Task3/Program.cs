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
            //  Interface Segregation Principle (ISP)
            // Single Responsibility Principle (SRP)

            Hero luckyMan = new Hero
            {
                Alias = "Luckyman",
                Balance = 5.0M,
                City = "NY",
                Country = "US",
                CurrencyCode = 124,
                FirstName = "Danny",
                LastName = "Adams",
                Gender = Gender.Male,
                LastTimeAddedFundsToBalance = DateTime.MinValue,
                PostIndex = "PO 90555",
                Power = "Luck",
                Salary = 15.0M,
                Street = "1st ave"
            };

            Electric electric = new Electric
            {
                Balance = 5.0M,
                City = "NY",
                Country = "US",
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                LastTimeAddedFundsToBalance = DateTime.MinValue,
                Salary = 15.0M,
                Street = "1st ave"
            };


            var financialDepartmentHero = new FinancialDepartment();
            financialDepartmentHero.ShowBalance(luckyMan);
            financialDepartmentHero.IncreaseSalary(luckyMan, 1M);
            var hrDepartmentHero = new HrDepartment();
            hrDepartmentHero.IncreaseSalary(luckyMan, 0.5M);

            var prDepartmentHero = new PrDepartment();
            prDepartmentHero.SendNewYearGreeting(luckyMan);
            Console.ReadLine();

            var financialDepartmentElectric = new FinancialDepartment();

            var prDepartmentElectric = new PrDepartment();
            var hrDepartmentElectric = new HrDepartment();

            financialDepartmentElectric.ShowBalance(electric);
            financialDepartmentElectric.IncreaseSalary(electric, 2M);
            hrDepartmentElectric.IncreaseSalary(electric, 0.5M);

            Console.ReadLine();
        }
    }
}
