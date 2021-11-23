using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MsSqlOtpBankDB
    {
        public List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    Name = "Dan",
                    Balance = 44.5M
                },
                new Client
                {
                    Name = "Misha",
                    Balance = 70.5M
                },
                new Client
                {
                    Name = "John",
                    Balance = -10.15M
                },
                new Client
                {
                    Name = "Monica",
                    Balance = -30.35M
                },
                new Client
                {
                    Name = "Joe",
                    Balance = 40.1M
                },
            };
        }
    }
}
