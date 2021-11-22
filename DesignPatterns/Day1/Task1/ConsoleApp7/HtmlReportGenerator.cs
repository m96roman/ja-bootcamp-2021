using System.Collections.Generic;

namespace ConsoleApp7
{
    public class HtmlReportGenerator : IReport
    {
        public string Get(List<Client> clients)
        {
            return $"html report for {clients.Count}";
        }
    }
}
