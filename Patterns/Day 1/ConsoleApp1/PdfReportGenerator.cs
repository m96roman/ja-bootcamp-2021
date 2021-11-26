using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class PdfReportGenerator : IBankReport
    {
        public string Get(List<Client> clients)
        {
            return $"pdf report for {clients.Count}";
        }
    }
}
