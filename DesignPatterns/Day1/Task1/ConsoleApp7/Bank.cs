using ConsoleApp7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Bank
    {
        private IReporter _reporter;
        public Bank(IReporter reporter)
        {
            _reporter = reporter;
        }

        public string Name { get; set; }
        public List<Client> Clients { get; set; }

        public string GetReport()
        {
           return _reporter.Get(Clients);
        }
    }
}
