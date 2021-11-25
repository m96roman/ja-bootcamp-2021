using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Transport
{
    public abstract class LogicalCompany
    {
        protected string Name { get; set; }
        protected string Adress { get; set; }

        public LogicalCompany(string name,string adress) 
        {
            Name = name;
            Adress = adress;
        }

        public abstract void DeliveritComplete();
    }
}
