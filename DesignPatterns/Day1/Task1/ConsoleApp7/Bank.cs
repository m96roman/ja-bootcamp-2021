using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }

        public string GetReport(IReportGenerator reportGenerator)
        {
            return reportGenerator.Get(Clients);
        }
    }
}
