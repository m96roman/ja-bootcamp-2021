using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   internal class Expert
   {
       public IDecorate Decorator { private get; set; }

        public Expert(IDecorate decorate)
        {
            Decorator = decorate;
        }

        public void Decorate()
        {
            Decorator.Decorate();
        }
    }
}
