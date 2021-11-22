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

            var hrDepartment = new HRAction();
            var model = new Model(luckyMan, hrDepartment);
            model.action.GetFullName();


            //var financialDepartment = new FinancialDepartment();
            //financialDepartment.ShowBalance(luckyMan);
            
            //hrDepartment.IncreaseSalary(luckyMan, 0.5M);
            //var prDepartment = new PrDepartment();
            //prDepartment.SendNewYearGreeting(luckyMan);
            Console.ReadLine();
        }
    }
}
