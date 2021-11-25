using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Client
    {
        public static void SimulateConvert(IMember member, IConvert convert)
        {
            member.Accept(convert);
        }
    }
}
