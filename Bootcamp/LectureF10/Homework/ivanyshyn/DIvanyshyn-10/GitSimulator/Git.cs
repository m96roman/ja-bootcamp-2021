using System;
using System.Collections.Concurrent;

namespace DIvanyshyn_10.GitSimulator
{
    class Git
    {
        public Git()
        {
            Commits = new ConcurrentBag<string>();
        }

        public ConcurrentBag<string> Commits { get; private set; }

        public void Push(string message)
        {
            Commits.Add(message);
        }
    }
}
