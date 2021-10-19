using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_TDD
{
    public interface ILogger
    {
        void WriteLine(Exception message);
    }
}
