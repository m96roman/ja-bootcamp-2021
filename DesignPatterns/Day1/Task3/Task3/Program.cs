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
            Person luckyMan = new Person
            {
                Alias = "Luckyman",
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,
                Power = "Luck",
            };

            //    Balance = 5.0M,

            //    CurrencyCode = 124,
            //   
            //    LastTimeAddedFundsToBalance = DateTime.MinValue,

            //    PostIndex = "PO 90555",
            //    Street = "1st ave"   
            //    City = "NY",
            //    Country = "US",

            //    Salary = 15.0M,
            

            var financialDepartment = new FinancialDepartment();
            financialDepartment.ShowBalance(luckyMan);
            financialDepartment.IncreaseSalary(luckyMan, 1M);
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(luckyMan, 0.5M);
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyMan);
            Console.ReadLine();
        }
    }
}
