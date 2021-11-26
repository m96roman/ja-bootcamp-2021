using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
  public  class Car
    {
        public string Name { get; set; }

        public string Chair { get; set; }

        public string Wheels { get; set; }

        public string Engine { get; set; }

        public string ListParts()
        {

            return $"Car {this.Name} parts: " + $"chair: {this.Chair} "+$"wheels: {this.Wheels}  "+$"engine: {this.Engine}" + "\n";
        }
    }
}
