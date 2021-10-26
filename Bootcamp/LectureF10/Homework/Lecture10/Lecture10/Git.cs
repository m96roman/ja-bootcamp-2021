using System.Collections.Concurrent;

namespace Lecture10
{
    public class Git
    {
        public ConcurrentBag<string> commits { get; set; } = new ConcurrentBag<string>();

        public void Push(string message)
        {
            commits.Add(message);
        }
    }
}


