using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //Порушений принцип Dependency injection - в нас всі департменти напряму звязані з Hero,
    // якщо звявляється новий персонал - фінансист, hr ... то треба писати окремий метод IncreaseSalary в класі HrDepartment для кожного  нового типу працівника..
    // Плюс нарушаєсться - DRY - краще всі проперті - Alias, Balance.. винести в батьківський клас щоб не дублювати - Employee наприклад. Можна 
    // в принципі зробити батьківський клас Employee для всіх сущностей і зробити всі методи віртуальними в кожньому дочірньому оверрайдити

    class Program
    {
        static void Main(string[] args)
        {
            IEmployee luckyMan = new Hero
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
            financialDepartment.IncreaseSalary(luckyMan, 1M);
            var hrDepartment = new HrDepartment();
            hrDepartment.IncreaseSalary(luckyMan, 0.5M);
            var prDepartment = new PrDepartment();
            prDepartment.SendNewYearGreeting(luckyMan);
            Console.ReadLine();
        }
    }
}
