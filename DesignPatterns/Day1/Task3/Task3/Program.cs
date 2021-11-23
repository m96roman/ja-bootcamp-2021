using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Single responsibility principle was violated,
        //Open-closed principle was violated,
        //Refactoring for restructurization.


        static void Main(string[] args)
        {
            Adderess adderess = new Adderess
            {
                City = "NY",
                Country = "US",
                PostIndex = "PO 90555",
                Street = "1st ave"
            };

            Hero luckyMan = new Hero(adderess)
            {
                Alias = "Luckyman",         
                FirstName = "John",
                LastName = "Smith",
                Gender = Gender.Male,      
                Power = "Luck",
                Salary = 15.0M,
                
                FinAccount = new Account
                {
                    Balance = 5.0M,
                    CurrencyCode = 124,
                    LastTimeAddedFundsToBalance = DateTime.MinValue,
                }
            };

            var financialDepartment = new FinancialDepartment();
            financialDepartment.ShowBalance(luckyMan);
            //financialDepartment.IncreaseSalary(luckyMan, 1M); //FinancialDepartment is not responsible for increasing Salary
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(luckyMan, 0.5M);
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyMan.Adderess);
            Console.ReadLine();
        }
    }
}
