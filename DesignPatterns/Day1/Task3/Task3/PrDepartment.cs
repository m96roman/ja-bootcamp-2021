using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrDepartment:PrAction
    {
        public void SendNewYearGreeting(Employee hero)
        {
            SendGreeting("Happy New Year!");
        }
    }
}
