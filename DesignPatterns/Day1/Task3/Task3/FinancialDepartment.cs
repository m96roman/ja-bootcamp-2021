using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment : ADepartment
    {
        public void ShowBalance(Hero hero)
        {
            Console.WriteLine($"{hero.GetFullName()} has {hero.Balance} on balnace");
        }
    }
}
