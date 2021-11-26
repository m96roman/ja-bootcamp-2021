using ConsoleApp3.Enums;
using ConsoleApp3.Models;
using System;
using ConsoleApp3.Interfaces;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Violated principles
             * SRP
             * 
             * used DI
             */

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

            IHeroActions luckyActions = new HeroActions(luckyMan);

            var financialDepartment = new FinancialDepartment(luckyActions);
            financialDepartment.ShowBalance();
            financialDepartment.IncreaseSalary(1M);

            var hrDepartment = new HrDepartment(luckyActions);
            hrDepartment.IncreaseSalary(0.5M);

            var prDepartment = new PrDepartment(luckyActions);
            prDepartment.SendNewYearGreeting();
        }
    }
}
