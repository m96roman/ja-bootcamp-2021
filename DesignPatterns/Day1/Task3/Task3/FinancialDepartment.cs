using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment
    {
        public void ShowBalance(IEmployee employee)
        {
            Console.WriteLine($"{employee.GetFullName()} has {employee.EmployeeBalance} on balnace");
        }

        public void IncreaseSalary(IEmployee employee, decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {employee.GetFullName()}");
            employee.IncreaseSalary(diff);
        }
    }
}
