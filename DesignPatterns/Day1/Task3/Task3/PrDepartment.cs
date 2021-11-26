using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrDepartment
    {
        public void SendNewYearGreeting(Employee employee)
        {
            if (employee is null)
            {
                throw new ArgumentNullException();
            }

            employee.SendGreeting("Happy New Year!");
        }
    }
}
