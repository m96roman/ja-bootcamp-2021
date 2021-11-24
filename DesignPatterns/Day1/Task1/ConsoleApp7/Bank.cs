using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *   Open Closed Prinsiple (OCP)
 */
namespace ConsoleApp7
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }

        public string GetReport(string type)
        {
            IReportGenerator report;

            if (type == "html")
            {
                report = new HtmlReportGenerator();                
            }
            else if (type == "pdf")
            {
                report = new PdfReportGenerator();               
            }
            else 
            {
                throw new ArgumentException();
            }

            return report.Get(Clients);
        }
    }
}
