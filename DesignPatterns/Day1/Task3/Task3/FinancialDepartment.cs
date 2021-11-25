using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment
    {
        public void ShowBalance(Person person)
        {
            Console.WriteLine($"{person.GetFullName()} has {person.Balance} on balnace");
        }

        public void IncreaseSalary(Person person, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {person.GetFullName()}");
            person.IncreaseSalary(diff);
        }
    }
}
