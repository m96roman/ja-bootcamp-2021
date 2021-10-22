using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFedakT8;

namespace ControllerUnitTest
{
    public class FakeLogger : ILogger
    {
        public List<string> message = new();

        public void WriteLine(string message)
        {
            this.message.Add(message);
        }
    }
}
