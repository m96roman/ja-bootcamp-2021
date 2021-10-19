using KFedak_Task9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_UnitTest1
{
    interface ITestable
    {
         void RunTest() { }

        void RunLogger(List<Phone> phones) { }
    }
}
