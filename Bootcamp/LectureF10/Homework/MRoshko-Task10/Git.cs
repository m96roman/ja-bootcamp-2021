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
      
        public Git()
        {
            bucketList = new ConcurrentBag<string>();
        }

        public void Push(string message)
        {

            Task.Run(() => bucketList.Add(message));

            Console.WriteLine(message);
        }
    }
}
