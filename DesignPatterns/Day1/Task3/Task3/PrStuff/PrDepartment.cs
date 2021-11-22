using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrDepartment
    {
        public void SendNewYearGreeting(IGreetingSender hero)
        {
            hero.SendGreeting("Happy New Year!");
        }
    }
}
