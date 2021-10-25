using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shyptur_Task10HW
{
    class Git
    {
        private static object _lock = new object();

        public ConcurrentBag<string> commits { get; set; } = new ConcurrentBag<string>();

        public void Push(string message)
        {

            commits.Add(message);

        }
    }
}
