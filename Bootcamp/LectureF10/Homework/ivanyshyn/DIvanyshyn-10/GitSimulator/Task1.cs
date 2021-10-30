using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DIvanyshyn_10.GitSimulator
{
    class Task1
    {
        public static async Task ExecuteAsync()
        {
            Git git = new();
            List<Task> developers = new();

            for (int i = 0; i < 8; i++)
            {
                developers.Add(Task.Run(() => WorkDay(88, git)));
            }

            await Task.WhenAll(developers.ToArray());

            //8*88=704
            Console.WriteLine($"Minions produced {git.Commits.Count} commits");
        }

        private static void WorkDay(int count, Git git)
        {
            for (int i = 0; i < count; i++)
            {
                git.Push($"Worker with id {Thread.CurrentThread.ManagedThreadId} produces commit number {i + 1}");
            }
        }
    }
}
