using ConsoleApp7.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp7
{
    public class PdfReportGenerator : IReporter
    {
        public string Get(List<Client> clients)
        {
            return $"pdf report for {clients.Count}";
        }

        public string GetReport(List<Client> clients)
        {
            return Get(clients);
        }
    }
}
