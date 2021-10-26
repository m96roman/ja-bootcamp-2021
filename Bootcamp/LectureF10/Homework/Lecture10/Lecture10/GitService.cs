using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture10
{
    public class GitService
    {
        public static async Task PrintCount()
        {
            var git = new Git();
            List<Task> list = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                list.Add(Task.Run(() => GitPush(git)));
            }

            Task.WaitAll(list.ToArray());
            Console.WriteLine($"Count: {git.commits.Count}");
        }

        public static void GitPush(Git git)
        {
            Thread.Sleep(1000);
            for (int i = 0; i < 88; i++)
            {
                git.Push(i.ToString());
            }
        }
    }
}
