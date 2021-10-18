using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace YaroslavB_Task10
{
    class Developer
    {
        private Random _ticket;
        private ISourceRepository _repository;
        private Commmit _commit;
        private static List<string> _features;
        private const int _numOfCommits = 88;
        private int _timeForFeature = 50;

        public string Name { get; }

        public Developer(string developerName, ISourceRepository repository)
        {
            Name = developerName;
            _repository = repository;
            _ticket = new Random();
            _features = new List<string>();
        }

        public void StartWorkDay()
        {
            string feature;
            string commitTitle = "Commit ";

            UpdateFeatureBase();

            for (int i = 1; i <= _numOfCommits; i++)
            {
                feature = CreateFeature();
                _commit = new Commmit(commitTitle + i, feature, Name);
                Push(_commit);

                Thread.Sleep(_timeForFeature);
            }
        }

        private void Push(Commmit newCommit)
        {
            _repository.Push(_commit);
        }

        private string CreateFeature()
        {
            var index = _ticket.Next(1, _features.Count);

            return _features[index];
        }

        private void UpdateFeatureBase()
        {
            int minLineLenght = 30;
            var fileExtension = "*.cs";

            if (_features != null && _features.Count > 0)
            {
                return;
            }

            var files = Directory.GetFiles("..\\..\\..\\", fileExtension, SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);

                foreach (var line in lines)
                {
                    var temp = line.Trim();

                    if (temp.Length > minLineLenght)
                    {
                        _features.Add(temp);
                    }
                }
            }
        }
    }
}
