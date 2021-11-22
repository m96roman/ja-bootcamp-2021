using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class HRAction:BaseAction {

        public HRAction(Employee employee) : base(employee)
        {
        }

        protected void IncreaseSalary(decimal amount)
        {
          employee.Salary += amount;
            
        }

        protected void DecreaseSalary(decimal amount)
        {
            employee.Salary -= amount;
        }
    }
}
