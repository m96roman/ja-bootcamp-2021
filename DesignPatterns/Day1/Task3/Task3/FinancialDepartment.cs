using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment //GetFullName, Balance, Salary
    {
        public void ShowBalance(IAccount hero)
        {
            Console.WriteLine($"{hero.GetFullName()} has {hero.FinAccount.Balance} on balnace");
        }


        //This should be FinancialDepartment responsible for
        //should be removed as not used
        //public void PaySalary()
        //{
        //    Balance += Salary;
        //}


        //This should be FinancialDepartment responsible for
        //should be removed as not used
        //public void IncreaseBalance(decimal amount)
        //{
        //    Balance += amount;
        //}


        //FinancialDepartment is not responsible for increasing Salary
        //public void IncreaseSalary(Hero hero, decimal diff)
        //{
        //    Console.WriteLine($"Increasing salary on {diff} for {hero.GetFullName()}");
        //    hero.IncreaseSalary(diff);
        //}
    }
}
