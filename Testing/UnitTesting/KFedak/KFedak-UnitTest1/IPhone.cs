using KFedak_UnitTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_Task9
{
    class IPhone : Phone,ITelephone
    {
        public IPhone(int battery, string name, ILogger logger) : base(battery, name, logger) { }
    }
}
