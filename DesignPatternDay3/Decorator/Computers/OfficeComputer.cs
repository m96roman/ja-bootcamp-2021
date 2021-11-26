using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class OfficeComputer : Computer
    {
        public string _type;

        public OfficeComputer(string type) : base(type)
        {
            this._type = type;
        }

        public override int Price()
        {
            return 12;
        }
    }
}
