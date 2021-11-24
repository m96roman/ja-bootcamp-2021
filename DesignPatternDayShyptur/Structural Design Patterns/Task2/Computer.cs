using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Computer
    {
      public  string name { get;  set; }
        public Computer(string name)
        {
            this.name = name;
        }
        public abstract void Display();
        
       
    }
}
