using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Application
    {
        public string Adress { get; set; }
        public string Product { get; set; }
        public ITransport Transport { get; set; }

        public Application(string adress,string product,ITransport transport)
        {
            this.Adress = adress;
            this.Product = product;
            this.Transport = transport;
        }

    }
}
