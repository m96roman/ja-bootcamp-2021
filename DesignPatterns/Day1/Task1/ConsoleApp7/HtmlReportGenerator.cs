using System.Collections.Generic;

namespace ConsoleApp7
{
    public class HtmlReportGenerator : IReportGenerator
    {
        public string Get(List<Client> clients)
        {
            return $"html report for {clients.Count}";
        }
    }
}
