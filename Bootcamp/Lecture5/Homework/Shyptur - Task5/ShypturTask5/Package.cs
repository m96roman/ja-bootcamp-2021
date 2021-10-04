using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
   public class Package
    {
        public double Size { get; set; }

        public string Title { get; set; }

        public string Recipient { get; set; }
        public Package(double size, string title, string recipient)
        {
            Size = size;
            Title = title;
            Recipient = recipient;
        }
    }
}
