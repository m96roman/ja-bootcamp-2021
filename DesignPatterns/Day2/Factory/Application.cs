using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Application
    {
        public string Address { get; set; }
        public string Product { get; set; }
        public ITransport Transport { get; set; }

        public Application(string address, string product,ITransport transport)
        {
            this.Address = address;
            this.Product = product;
            this.Transport = transport;
        }

    }
}
