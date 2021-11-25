using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
        private IReport _report;

        public string GetReportHtml(string type)
        {
            if (type == "html")
            {
                _report = new HtmlReportGenerator();
                return _report.Get(Clients);
            }

            throw new ArgumentException();
        }

        public string GetReportPdf(string type)
        {
            if (type == "pdf")
            {
                _report = new PdfReportGenerator();
                return _report.Get(Clients);
            }

            throw new ArgumentException();
        }
    }
}
