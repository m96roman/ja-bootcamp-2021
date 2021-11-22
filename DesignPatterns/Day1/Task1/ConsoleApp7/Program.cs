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
                Clients = clients, 
                
            };
            Console.WriteLine(otp.GetReportHtml("html"));
            Console.WriteLine(otp.GetReportPdf("pdf"));

            Console.ReadLine();

            // Task violets OCP, in case if we need to add report of different type we would have to modify getReport() method
        }
    }
}
