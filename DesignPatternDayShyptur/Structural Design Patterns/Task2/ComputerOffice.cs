using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public class ComputerOffice : Computer
    {
       
       
        public ComputerOffice() : base("Office PC") { }
     
        public override void Display()
        {
            Console.WriteLine(this.name);
        }
    }
}
