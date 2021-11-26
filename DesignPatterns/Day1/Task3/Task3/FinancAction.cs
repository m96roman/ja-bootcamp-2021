using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class FinancAction : BaseAction
    {

        public FinancAction(Employee employee) : base(employee)
        {
        }

        protected void IncreaseBalance(decimal amount)
        {
            employee.Balance += amount;
        }

        protected void PaySalary()
        {
            employee.Balance += employee.Salary;
        }
    }
}
