using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimulateGIT
{
    class Office
    {
        private const int _devCount = 8; //8
        private const int _commitsPerDeveloper = 88;
        private readonly Git _git;
        private List<Task> _developers;
        private Random _timeForFeature;

        public Office(Git git)
        {
            _git = git;
            _developers = new List<Task>();
            _timeForFeature = new Random();
        }

        public void StartWorkday()
        {
            Console.WriteLine("Starting new workday....\n");

            for (int i = 1; i <= _devCount; i++)
            {
                string devName = "Ivan_" + i; //:)
                var developer = new Task(() => CommitFeatures(devName));
                developer.Start();
                _developers.Add(developer);
            }

            Task.WaitAll(_developers.ToArray());
            Console.WriteLine("\nEnd of the workday.");
        }

        private void CommitFeatures(string developerNumber)
        {
            for (int i = 1; i <= _commitsPerDeveloper; i++)
            {
                int delay = _timeForFeature.Next(5, 10) * 137;
                Task.Delay(delay).Wait();
                string commit = $"Developer {developerNumber}, commit: {i}/{_commitsPerDeveloper}, time spent: {delay}";
                _git.Push(commit);
            }
        }
    }
}
