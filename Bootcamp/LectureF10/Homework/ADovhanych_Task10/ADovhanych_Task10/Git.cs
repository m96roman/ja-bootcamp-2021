using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task10
{
    class Git
    {
        public List<string> messageCollection = new List<string>();

        private static object _lock = new object();
        public void Push(string message)
        {
            lock (_lock)
            {
                for (int i = 0; i < 88; i++)
                {
                    messageCollection.Add(message);
                }
            }
        }
    }
}
