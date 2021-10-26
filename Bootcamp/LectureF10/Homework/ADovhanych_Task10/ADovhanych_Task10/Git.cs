using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADovhanych_Task10
{
    class Git
    {
        public ConcurrentBag<string> MessageCollection { get; private set; }
        
        public Git()
        {
            MessageCollection = new ConcurrentBag<string>();
        }

        public void Push(string message)
        {
            for (int i = 0; i < 88; i++)
            {
                MessageCollection.Add(message);
            }
        }
    }
}
