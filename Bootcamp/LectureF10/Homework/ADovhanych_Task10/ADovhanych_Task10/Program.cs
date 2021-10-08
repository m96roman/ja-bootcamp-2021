using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ADovhanych_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            var oppenedThreads = new List<Task>();
            var git = new Git();

            for (int i = 0; i < 8; i++)
            {
                oppenedThreads.Add(Task.Run(() => git.Push("commit")));
            }

            Task.WaitAll(oppenedThreads.ToArray());
            Console.WriteLine(git.messageCollection.Count);
        }
    }
}
