using System.Collections.Generic;

namespace ConsoleApp7
{
    public interface IReportGenerator
    {
        string Get(List<Client> clients);
    }
}