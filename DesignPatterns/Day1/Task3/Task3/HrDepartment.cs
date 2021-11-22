using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HrDepartment
    {
        public void IncreaseSalary(Hero hero, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {hero.GetFullName()}");
            hero.IncreaseSalary(diff);
        }
    }
}
