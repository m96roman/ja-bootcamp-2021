using System.Collections.Generic;

namespace ConsoleApp7
{
    public class PdfReportGenerator : IReportGenerator
    {
        public string Get(List<Client> clients)
        {
            return $"pdf report for {clients.Count}";
        }
    }
}
