using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Task1
{
    public class Git
    {
        public ConcurrentBag<string> Commits
        {
            get
            {
                return new ConcurrentBag<string>();
            }
            set
            {
                Commits = value;
            }
        }

        public void Push(string message)
        {
            Console.WriteLine(message);
            Commits.Add(message);
        }
    }
}
