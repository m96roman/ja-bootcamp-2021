using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPlyskaLect10
{
    public class Git
    {
        
        public ConcurrentBag<string> GitStoredMessage { get; private set; } 

        public Git()
        {
            GitStoredMessage = new ConcurrentBag<string>();
        }

        public void Push(string message)
        {
            GitStoredMessage.Add(message);
        }

        public  void WorkWithGit(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                Push($"dev push {Thread.CurrentThread.Name}");
            }
        }

        public  void ShowAllCommits()
        {
            Console.WriteLine($"8 developers were made {GitStoredMessage.Count} per day");
        }
    }
}
