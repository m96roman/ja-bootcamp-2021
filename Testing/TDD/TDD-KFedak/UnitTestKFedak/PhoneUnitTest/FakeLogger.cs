using System;
using System.Collections.Generic;
using KFedak_TDD;

namespace PhoneUnitTest
{
    public class FakeLogger : ILogger
    {
        public List<string> message = new();

        public void WriteLine(Exception message)
        {
            this.message.Add(message.Message);
        }
    }
}
