using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HomeComputer : Computer
    {
        public string _type;

        public HomeComputer(string type) : base(type)
        {
            this._type = type;
        }

        public override int Price()
        {
            return 10;
        }
    }
}
