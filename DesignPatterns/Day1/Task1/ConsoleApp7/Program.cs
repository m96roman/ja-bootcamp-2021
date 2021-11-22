using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //open-closed principle
            MsSqlOtpBankDB db = new MsSqlOtpBankDB();
            List<Client> clients = db.GetClients();
            var otp = new Bank
            {
                Name = "Otp",
                Clients = clients
            };

            IReportGenerator htmlReport = new HtmlReportGenerator();
            Console.WriteLine(htmlReport.Get(otp.Clients));
            IReportGenerator pdfReport = new PdfReportGenerator();
            Console.WriteLine(pdfReport.Get(otp.Clients));
            Console.ReadKey();
        }
    }
}
