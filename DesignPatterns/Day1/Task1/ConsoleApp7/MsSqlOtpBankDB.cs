using ConsoleApp7.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MsSqlOtpBankDB : Irepository
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
