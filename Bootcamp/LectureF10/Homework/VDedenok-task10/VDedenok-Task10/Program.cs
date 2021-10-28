using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace VDedenok_Task10
{
    class Program
    {
        static List<string> commits = new List<string>();

        class Git
        {
            private static object _lock = new object();

            public void Push(string message)
            {
                lock (_lock)
                {
                    commits.Add(message);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                tasks.Add(Task.Run(() => dailyCommits()));
                Console.WriteLine();
            }


            static void dailyCommits()
            {
                Git gitUser = new Git();
         
                for (int i = 0; i < 88; i++)
                {
                    gitUser.Push($"Commit # {i}.");
                }
             
            }

            Task.WaitAll(tasks.ToArray());
          
            Console.WriteLine(commits.Count);
        }
    }
}
