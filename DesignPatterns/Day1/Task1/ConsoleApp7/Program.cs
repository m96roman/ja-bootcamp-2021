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

            // Open-closed prinsiple is used. Our program give us possibility to get Html report and Pdf report.

            Console.WriteLine(otp.GetReport(new HtmlReportGenerator()));
            Console.WriteLine(otp.GetReport(new PdfReportGenerator()));

            Console.ReadKey();
        }
    }
}
