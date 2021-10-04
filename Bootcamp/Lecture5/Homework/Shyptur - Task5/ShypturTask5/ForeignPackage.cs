using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShypturTask5
{
    public class ForeignPackage : Package
    {
        public string SenderCountry { get; set; }
        public ForeignPackage(double size, string title, string recipient, string senderCountry) : base(size, title, recipient)
        {
            SenderCountry = senderCountry;
        }
    }
}
