using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> Clients { get; set; }

        public string GetReport(IReportGenerator report)
        {
            return report.Get(Clients);
        }
    }
}
