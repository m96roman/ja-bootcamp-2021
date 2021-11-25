using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class GameComputer : Computer
    {
        public string _type;
       
        public GameComputer(string type) : base(type)
            {
            this._type = type;
        }

        public override int Price()
        {
            return 15;
        }
    }
}
