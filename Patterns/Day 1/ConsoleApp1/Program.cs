using ConsoleApp1.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Violated principles
             * DIP
             * OCP
             * 
             * used - DI
             */

            MsSqlOtpBankDB db = new MsSqlOtpBankDB();
            List<Client> clients = db.GetClients();

            Bank otp = new Bank
            {
                Name = "Otp",
                Clients = clients
            };

            Console.WriteLine(otp.GetHtmlReport());
            Console.WriteLine(otp.GetPdfReport());
        }
    }
}
