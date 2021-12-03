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
    }
}
