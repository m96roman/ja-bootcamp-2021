using ConsoleApp1.Models;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }

        private IBankReport _bankReport;

        public string GetHtmlReport()
        {
            _bankReport = new HtmlReportGenerator();
            return _bankReport.Get(Clients);
        }

        public string GetPdfReport()
        {
            _bankReport = new PdfReportGenerator();
            return _bankReport.Get(Clients);
        }
    }
}