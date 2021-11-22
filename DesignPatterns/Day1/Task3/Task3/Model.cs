using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   public 
       class Model
    {
        public Employee employee;
        public Action action;

        public Model(Employee employee,Action action)
        {
            this.employee = employee;
            this.action = action;
        }
    }
}
