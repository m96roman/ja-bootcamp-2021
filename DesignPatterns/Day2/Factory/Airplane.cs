using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Airplane : ITransport
    {
        public string Delivery()
        {
          return "deliver by airplane";
        }
    }
}
