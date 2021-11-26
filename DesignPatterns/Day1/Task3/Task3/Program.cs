using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //single resposibility
        static void Main(string[] args)
        {
            Employee luckyMan = new Employee
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

            var hrAction = new HrDepartment(luckyMan);
            hrAction.IncreaseSalaryHr(10);

            var finAction = new FinancialDepartment(luckyMan);
            finAction.ShowBalance();

            var prAction = new PrDepartment(luckyMan);
            prAction.SendNewYearGreeting();
            Console.ReadLine();
        }
    }
}
