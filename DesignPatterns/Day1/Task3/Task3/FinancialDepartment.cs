using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment: IIncreaseSalary
    {
        public void ShowBalance(HumanBase hero)
        {
            Console.WriteLine($"{hero.GetFullName()} has {hero.Balance} on balnace");
        }

        public void IncreaseSalary(IPerson hero, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {hero.GetFullName()}");
        }
    }
}
