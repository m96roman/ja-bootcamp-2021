using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var listOfThreads = new List<Task>();
            var git = new Git();
           
            for (int i = 0; i < 8; i++)
            {
                listOfThreads.Add(Task.Run(() => SimulateWork(git)));
            }

            await Task.WhenAll(listOfThreads);

            Console.WriteLine($"Developers have done {git.Commits.Count}");          
        }

        static void SimulateWork(Git git)
        {
            for (int i = 0; i < 88; i++)
            {
                git.Push($"Comment from developer {Task.CurrentId}");
            }
        }
    }
}
