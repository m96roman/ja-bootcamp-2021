using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedakTask4
{
    class IPhone : Phone,ITelephone
    {
        public IPhone(int battery, string name) : base(battery, name) { }
    }
}
