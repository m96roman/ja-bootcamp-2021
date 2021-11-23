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
           
            Console.WriteLine(otp.GetReport(new HtmlReportGenerator()));
            Console.WriteLine(otp.GetReport(new PdfReportGenerator()));
            Console.ReadLine();  
        }
    }
}
// Open Close method has been aplied for this program. GetReport method of Bank class has been changed such,
// that now it can be extended by creating new class which applies IReport iterface.