using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace SimulateGIT
{
    class Git
    {
        private readonly ILogger _logger;
        private ConcurrentBag<string> _commits;

        public Git() : this(new Logger()) {}

        public Git(ILogger logger)
        {
            _commits = new ConcurrentBag<string>();
            _logger = logger;
        }

        public void Push(string commit)
        {
            Task.Run(() => _commits.Add(commit));
            _logger.Log($"Received new commit: <{commit}>");
        }

        public int GetCommitsCount()
        {
            return _commits.Count;
        }
    }
}
