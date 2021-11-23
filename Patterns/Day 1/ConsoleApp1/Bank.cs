using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
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

/*
public string GetReport(string type)
{
    if (type == "html")
    {
        var htmlReport = new HtmlReportGenerator();
        return htmlReport.Get(Clients);
    }
    else if (type == "pdf")
    {
        var pdfReport = new PdfReportGenerator();
        return pdfReport.Get(Clients);
    }

    throw new ArgumentException();
}
*/
