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

        //Problem with this method is it depends on 'magic' string type
        public string GetReport(IReportGenerator reportGenerator)
        {
            return reportGenerator.Get(Clients);
        }
    }
}
