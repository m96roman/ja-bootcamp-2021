using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrDepartment:PrAction
    {
        public PrDepartment(Employee employee) : base(employee) { }
        public void SendNewYearGreeting()
        {
            SendGreeting("Happy New Year!");
        }
    }
}
