using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FinancialDepartment:FinancAction
    {
        public FinancialDepartment(Employee employee) : base(employee) { }
        public void ShowBalance()
        {
            Console.WriteLine($"{employee.GetFullName()} has {employee.Balance} on balnace");
        }

        public void GiveSalary()
        {
            PaySalary();
        }
    }
}
