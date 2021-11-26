using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces
{
    interface IBankReport
    {
        string Get(List<Client> clients);
    }
}
