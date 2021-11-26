using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class HtmlReportGenerator : IBankReport
    {
        public string Get(List<Client> clients)
        {
            return $"html report for {clients.Count}";
        }
    }
}
