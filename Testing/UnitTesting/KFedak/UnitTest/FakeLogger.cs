using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFedak_UnitTest1
{
    public class FakeLogger : ILogger
    {
        public List<string> message = new List<string>();

        public void WriteLine(Exception message)
        {
            this.message.Add(message.Message);
        }
    }
}
