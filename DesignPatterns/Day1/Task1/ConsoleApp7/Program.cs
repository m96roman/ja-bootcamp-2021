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
            MsSqlOtpBankDB db = new MsSqlOtpBankDB();
            List<Client> clients = db.GetClients();
            Bank otp = new Bank
            {
                Name = "Otp",
                Clients = clients
            };

            //"Open-closed" principle was violated — in order to add new report, you had to change the class 'Bank' that uses this report.
            //after refactoring:

            //both objects implement the interface IReportGenerator
            var htmlReport = new HtmlReportGenerator();
            var pdfReport = new PdfReportGenerator();

            //for 'Bank' class it does not matter which report object was passed in the parameter 
            Console.WriteLine(otp.GetReport(htmlReport));
            Console.WriteLine(otp.GetReport(pdfReport));
        }
    }
}
