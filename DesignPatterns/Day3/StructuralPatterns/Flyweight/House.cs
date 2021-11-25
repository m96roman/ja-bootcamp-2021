using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   internal abstract class House
   {
       public int Floor;

       public abstract void BuildHouse(Street street);
   }
}
