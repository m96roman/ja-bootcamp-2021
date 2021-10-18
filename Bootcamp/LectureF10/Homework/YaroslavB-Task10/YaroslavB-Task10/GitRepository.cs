using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace YaroslavB_Task10
{
    class GitRepository : ISourceRepository
    {
        private ConcurrentBag<Commmit> _commits;
        private List<Commmit> _commitsToDisplay;
        private List<string> _contributors;

        public event EventHandler<Commmit> OnPushRequest;

        public GitRepository()
        {
            _commits = new ConcurrentBag<Commmit>();
            _commitsToDisplay = new List<Commmit>();
            _contributors = new List<string>();
        }

        public void Push(Commmit commit)
        {
            _commits.Add(commit);
            OnPushRequest?.Invoke(this, commit);
            //ProcessCommit(commit);
        }

        private void ProcessCommit(Commmit commit)
        {
            if (!_contributors.Contains(commit.Autor))
            {
                _contributors.Add(commit.Autor);
                OnPushRequest?.Invoke(this, commit);
            }
            else
            {
                var index = _contributors.IndexOf(commit.Autor);
                _commitsToDisplay[index] = commit;
            }

            string temp = "";

            foreach (var commitToDisp in _commitsToDisplay)
            {
                temp += commitToDisp;
            }

            //Console.Clear();
            //Console.WriteLine(temp);
        }
    }
}
