using ConsoleApp7.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp7
{
    public class HtmlReportGenerator : IReporter
    {
        public string Get(List<Client> clients)
        {
            return $"html report for {clients.Count}";
        }

        public string GetReport(List<Client> clients)
        {
           return Get(clients);
        }
    }
}
