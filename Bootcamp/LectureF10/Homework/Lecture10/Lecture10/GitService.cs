using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lecture10
{
    public class GitService
    {
        public static async Task PrintCount()
        {
            var git = new Git();
            var listOfThreads = new List<Task>();

            for (int i = 0; i < 8; i++)
            {
                await Task.Run(() => GitPush(git));
            }

            Console.WriteLine($"Count: {git.commits.Count}");
        }

        public static void GitPush(Git git)
        {
            for (int i = 0; i < 88; i++)
            {
                git.Push(i.ToString());
            }
        }
    }
}
