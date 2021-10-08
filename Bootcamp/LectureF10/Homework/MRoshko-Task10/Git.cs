using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace MRoshko_Task10
{
    class Git
    {
        public ConcurrentBag<string> bucketList;

        private static object _lock = new object();

        public Git() 
        {
            bucketList = new ConcurrentBag<string>();
        }

        public void Push(string message)
        {
            lock(_lock)
            {
                Task.Run(() => bucketList.Add(message));         
            }
          
            Console.WriteLine(message);
        }
    }
}
