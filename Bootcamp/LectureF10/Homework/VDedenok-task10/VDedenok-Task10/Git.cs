using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDedenok_Task10
{
    class Git
    {
        private static object _lock = new object();

        public void Push(string message, List<string> commits)
        {
            lock (_lock)
            {
                commits.Add(message);
            }
        }
    }
}
