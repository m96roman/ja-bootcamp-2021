using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Bank:IBank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
     
        public string GetHtmlReport()
        {
            var htmlReport = new HtmlReportGenerator();
            return htmlReport.Get(Clients);
        }
        public string GetPdfReport()
        {
            var pdfReport = new PdfReportGenerator();
            return pdfReport.Get(Clients);
        }    
    }
}
