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
            //so, following SRP the finance/hr/pr stuff has to be one class/interface per department
            //But as i think Person with his basic fields has to be the same for all departments
            Person luckyMan = new Person
            {
                Alias = "Luckyman",
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                Power = "Luck",
            };

            FinancialReporter luckyFinanceMan = new FinancialReporter
            {
                Person = luckyMan,
                Balance = 5.0M,
                CurrencyCode = 124,
                LastTimeAddedFundsToBalance = DateTime.MinValue
            };
            var financialDepartment = new FinancialDepartment();
            financialDepartment.ShowBalance(luckyFinanceMan);
            financialDepartment.IncreaseSalary(luckyFinanceMan, 1M);


            Worker luckyWorker = new Worker { Person = luckyMan, Salary = 15.0M };
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(luckyWorker, 0.5M);

            GreetingsSender luckyGreetingsSender = new GreetingsSender
            {
                PostIndex = "PO 90555",
                Street = "1st ave",
                City = "NY",
                Country = "US",
            };
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyGreetingsSender);

            Console.ReadLine();
        }
    }
}
