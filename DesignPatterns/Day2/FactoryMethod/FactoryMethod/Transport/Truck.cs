using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Transport
{
    public class Truck : LogicalCompany 
    {           
        public Truck(string name ,string adress): base(name,adress) 
        { 
        }

        public override void DeliveritComplete()
        {
            Console.WriteLine($"{Name} were sent to the {Adress} by Track"); 
        }
    }
}
