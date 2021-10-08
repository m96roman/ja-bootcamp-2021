using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    public class Git
    {
        public List<string> commits = new List<string>();
        private static object _lock = new object();

        public void Push(string message)
        {
            lock (_lock)
            {
                Console.WriteLine(message);
                commits.Add(message);
            }
        }
    }
}
