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
            var financialDepartmentsHero = new FinancialDepartment();
            HeroFinancialInfo heroFinancial = new HeroFinancialInfo
            {
                FirstName = "Anna",
                LastName = "Smith",
                Salary = 15.0m,
                Balance = 5.0M
            };

            financialDepartmentsHero.ShowBalance(heroFinancial);
            financialDepartmentsHero.IncreaseSalary(heroFinancial, 1M);
           
            
            HeroHrInfo hrsHero = new HeroHrInfo
            {
                FirstName = "Anna",
                LastName = "Smith",
                Salary = 15.0m
            };
           
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(hrsHero, 0.5M);

            HeroPrInfo prsHero = new HeroPrInfo
            {
                City = "Uzhgorod",
                Street = "Minayska",
                PostIndex = "88000",
                Country = "Ukraine"
            };
           
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(prsHero);
            Console.ReadLine();
        }
    }
}
// In this program there were inmplemented Single responsibility principle.
