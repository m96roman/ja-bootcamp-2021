using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IIncreaseSalary
    {
        void IncreaseSalary(IPerson hero, decimal diff);
    }
}
