using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HrDepartment : HRAction
    {
        public HrDepartment(Employee employee) : base(employee) { }
        public void IncreaseSalaryHr(decimal diff)
        {
            Console.WriteLine($"Increasing salary on {diff} for {employee.GetFullName()}");
            IncreaseSalary(diff);
        }
    }
}
