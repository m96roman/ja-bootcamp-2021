using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HrDepartment:HRAction
    {
        public void IncreaseSalary(Employee hero, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {GetFullName()}");
            IncreaseSalary(diff);
        }
    }
}
