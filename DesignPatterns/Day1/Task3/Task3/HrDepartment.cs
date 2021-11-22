using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class HrDepartment
    {
        public void IncreaseSalary(IEmployee employ, decimal diff)
        {
            if (employ is null)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine($"Increasing salary on {diff} for {employ.GetFullName()}");
            employ.IncreaseSalary(diff);
        }
    }
}
