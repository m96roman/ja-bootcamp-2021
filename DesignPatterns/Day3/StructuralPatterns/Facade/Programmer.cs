using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Programmer
    {
        public void Create(VisualStudioFacade visualStudioFacade)
        {
            visualStudioFacade.Start();
        }
    }
}
