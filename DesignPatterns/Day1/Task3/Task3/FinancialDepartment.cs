using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment:FinancAction
    {
        public void ShowBalance(Employee hero)
        {
            Console.WriteLine($"{GetFullName()} has {hero.Balance} on balnace");
        }
    }
}
